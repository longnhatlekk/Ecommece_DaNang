using AutoMapper;
using Azure.Core;
using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommece_DaNang.UCard
{
    public class CardService : ICardService

    {
        private AppDbcontext _context;
        private IMapper _mapper;

        public CardService(AppDbcontext context,IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }
        public void Addtocard(CardModel card, int UserId)
        {

            var product = _context.Products.Include(x => x.ProductOptions).FirstOrDefault(x => x.ProductId == card.ProductID);
            if (product == null) throw new Exception("No product");
            var selectOption = product.ProductOptions.FirstOrDefault(x => x.productOptionId == card.ProductOptionID);
            var selectImage = product.ImageProducts.FirstOrDefault(x => x.ImageId == card.ImageId);
            if (selectOption == null) throw new Exception("No option product");
          
                var existingCartItem = _context.Cards.FirstOrDefault(c =>
                      c.UserId == UserId && c.ProductId == card.ProductID && c.ProductOptionID == card.ProductOptionID && card.ImageId == c.ImageId);
                if (existingCartItem != null)
                {
                    if (card.quantity == 0)
                    {
                        throw new Exception("Fail card");
                    }
                    else
                    {
                        existingCartItem.Quantity += card.quantity;
                        if (existingCartItem.Quantity > product.Quantity)
                        {
                            existingCartItem.Quantity = product.Quantity;
                           throw new Exception ("Bạn đã có " + product.Quantity + " sản phẩm trong giỏ hàng. Không thể thêm số lượng đã chọn vào giỏ hàng vì sẽ vượt quá giới hạn mua hàng của bạn.");
                        }
                        existingCartItem.Price += card.quantity * selectOption.Price;
                    }
                }
                else
                {
                    if (card.quantity > 0)
                    {
                        var newCartItem = new Card
                        {
                            UserId = UserId,
                            ProductId = (int)card.ProductID,
                            Quantity = card.quantity,
                            Price = card.quantity * selectOption.Price,
                            
                        };
                    newCartItem.ProductOptionID = card.ProductOptionID;
                    newCartItem.ImageId = card.ImageId;
                        _context.Cards.Add(newCartItem);
                        _context.SaveChanges();
                    }
                    else
                    {
                       
                        throw new Exception("Invalid quantity");
                    }
                }
            

        }

        public void updateCard(Updatequantity update, int UserId)
        {
            var cartItem = _context.Cards.FirstOrDefault(c =>
                     c.UserId == UserId && c.CardId == update.cartID);

            if (cartItem != null)
            {

                var product = _context.Products.FirstOrDefault(p => p.ProductId == cartItem.ProductId);
                var selectoption = _context.productoptions.FirstOrDefault(x => x.productOptionId == cartItem.ProductOptionID);
                if (update.quantity != -1 && update.quantity != 1)
                {
                    cartItem.Quantity = update.quantity;
                }
                if (update.quantity == -1 || update.quantity == 1)
                {
                    cartItem.Quantity += update.quantity;
                }

                cartItem.Price = (int)Math.Round((decimal)(selectoption.Price * cartItem.Quantity));
                if (cartItem.Quantity > product.Quantity)
                {
                    cartItem.Quantity = product.Quantity;
                    _context.SaveChangesAsync();
                    throw new Exception("Bạn đã có " + product.Quantity + " sản phẩm trong giỏ hàng. Không thể thêm số lượng đã chọn vào giỏ hàng vì sẽ vượt quá giới hạn mua hàng của bạn.");
                }
                if (cartItem.Quantity < 1)
                {
                    _context.Cards.Remove(cartItem);
                    _context.SaveChangesAsync();

                }

                _context.SaveChangesAsync();

            }
        }

        public async Task<List<ViewCart>> ViewCard(int UserId)
        {
            
            var viewCarts = await _context.Cards
               .Include(p => p.product)
               .Include(x => x.ImageProducts)
               .Include(x => x.ProductOptions)                             
               .Where(u => u.UserId == UserId && u.product.Quantity > 0)

               .Select(g => new ViewCart
               {
                   CartId = g.CardId,
                   productName = g.product.ProductName,
                   ProductId = (int)g.ProductId,
                   PriceCart = g.Price,
                   quantityCart = g.Quantity,
                   quantityProduct = (int)g.product.Quantity,
                   imageproduct = g.ImageProducts.Image,
                   Color = g.ImageProducts.Color,

                   PriceProduct = (int) g.ProductOptions.Price,
                   Option = g.ProductOptions.productOptionName
                   
                   

               })
               .ToListAsync();


            return viewCarts;
        }

       
    }
}
