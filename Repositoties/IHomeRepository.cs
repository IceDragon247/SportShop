namespace SportShop
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Product>> GetProducts(string sTerm = "", int catetoryId = 0);
        Task<IEnumerable<Category>> Categories();

    }
}