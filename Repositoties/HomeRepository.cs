

using Microsoft.EntityFrameworkCore;

namespace SportShop.Repositoties
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _db;
        public HomeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        
        public async Task<IEnumerable<Category>> Categories() 
        {
            return await _db.Categories.ToListAsync();
        }
        public async Task<IEnumerable<Product>> GetProducts(string sTerm="",int catetoryId = 0)
        {
            sTerm = sTerm.ToLower();
            IEnumerable<Product> products = await (from product in _db.Products
                            join category in _db.Categories
                            on product.CategoryId equals category.Id
                            where string.IsNullOrWhiteSpace(sTerm) || (product!=null && product.ProductName.ToLower().StartsWith(sTerm))
                            select new Product
                            {
                                Id = product.Id,
                                Image = product.Image,
                                ProductName = product.ProductName,
                                Category = product.Category,
                                Price = product.Price,
                                CategoryName = category.CategoryName,
                            }
                            ).ToListAsync();
            if (catetoryId > 0)
            {
                products = products.Where(a => a.CategoryId == catetoryId).ToList();
            }
            return products;
        }
    }
}
