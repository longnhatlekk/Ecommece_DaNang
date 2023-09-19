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

            var product = _context.Products.FirstOrDefault(x => x.ProductId == card.ProductID);
            if(product != null)
            {
                var existingCartItem = _context.Cards.FirstOrDefault(c =>
                      c.UserId == UserId && c.ProductId == card.ProductID);
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
                        existingCartItem.Price += card.quantity * (int)Math.Round((decimal)(product.Price));
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
                            Price = card.quantity * (int)Math.Round((decimal)(product.Price)),
                            
                        };
                        _context.Cards.Add(newCartItem);
                        _context.SaveChanges();
                    }
                    else
                    {
                       
                        throw new Exception("Invalid quantity");
                    }
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
                if (update.quantity != -1 && update.quantity != 1)
                {
                    cartItem.Quantity = update.quantity;
                }
                if (update.quantity == -1 || update.quantity == 1)
                {
                    cartItem.Quantity += update.quantity;
                }

                cartItem.Price = (int)Math.Round((decimal)(product.Price * cartItem.Quantity));
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
               .ThenInclude(p => p.ImageProducts)
               .Where(u => u.UserId == UserId && u.product.Quantity > 0)

               .Select(g => new ViewCart
               {
                   CartId = g.CardId,
                   productName = g.product.ProductName,
                   ProductId = (int)g.ProductId,
                   quantityProduct = (int)g.product.Quantity,
                   PriceProduct = (int)Math.Round((decimal)(g.product.Price)),
                   ImageProduct = g.product.ImageProducts.FirstOrDefault().Image

               })
               .ToListAsync();


            return viewCarts;
        }

       
    }
}
