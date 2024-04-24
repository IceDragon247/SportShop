namespace SportShop.Repositoties
{
    public interface IUserOrderRepository
    {
        Task<IEnumerable<Order>> UserOrder();
    }
}