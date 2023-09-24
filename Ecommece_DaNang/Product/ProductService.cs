using AutoMapper;
using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Model;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Ecommece_DaNang.Product
{
    public class ProductService : IProductService
    {
        private AppDbcontext _context;
        private IMapper _mapper;

        public ProductService(AppDbcontext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<ProductModel>> getallProduct()
        {
            var products = await _context.Products.Include(u => u.ImageProducts).Where(x => x.IsDeleted  == true).ToListAsync();

            
            

            var productModels = _mapper.Map<List<ProductModel>>(products);

            return productModels;
        }



        public async Task<List<CateProducts>> GetCateProducts(string CateId)
        {
            var product = await _context.Products.Include(x => x.ImageProducts).Where(x => x.CateId == CateId && x.IsDeleted == true).ToListAsync();
            var mapper = _mapper.Map<List<CateProducts>>(product);
            return mapper;
        }

        public async Task<List<HotProduct>> getHotProduct()
        {
            var product = await _context.Products.Include(x => x.ImageProducts).Include(x=> x.ProductOptions)
                .Where(x => x.Discount >= 15 && x.IsDeleted == true).ToListAsync();
            var mapper = _mapper.Map<List<HotProduct>>(product);
            return mapper;
        }

        public async Task<AllProductModel> getProducts(int productId)
        {
            var product = _context.Products.Include(u=> u.ProductOptions)
                .Include(u=>u.ImageProducts).Where(x=> x.IsDeleted == true)
                .FirstOrDefault(Products => Products.ProductId == productId);
            var mapper = _mapper.Map<AllProductModel>(product);
            return mapper;
        }

        public async Task<List<ProductModel>> SearchProduct(string ProductName)
        {
            var product = await _context.Products.Include(x => x.ImageProducts)
                .Where(x => x.ProductName.Contains(ProductName) && x.IsDeleted == true).ToListAsync();
            var mapper = _mapper.Map<List<ProductModel>>(product);
            return mapper;
        }
    }
}
