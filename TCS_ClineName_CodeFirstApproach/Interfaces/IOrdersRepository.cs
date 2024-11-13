

using TCS_ClineName_CodeFirstApproach.Entities;

namespace Employee_Dapper.Interface
{
    public interface IOrdersRepository
    {
        Task<List<Orders>> GetOrders();
        Task<Orders> GetOrderById(int orderid);
        Task<int> AddOrder(Orders orderdetail);
        Task<bool> DeleteOrderById(int orderid);
        Task<bool> UpdateOrder(Orders orderdetail);
    }
}
