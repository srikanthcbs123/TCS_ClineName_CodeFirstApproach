using Employee_Dapper.Interface;
using Microsoft.EntityFrameworkCore;
using TCS_ClineName_CodeFirstApproach.DbConnect;
using TCS_ClineName_CodeFirstApproach.Entities;

namespace TCS_ClineName_CodeFirstApproach.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly CompanyOrdersContext _companyOrdersContext;
        public OrdersRepository(CompanyOrdersContext companyOrdersContext)
        {
            _companyOrdersContext = companyOrdersContext;
        }
        public async Task<int> AddOrder(Orders orderdetail)
        {
            await _companyOrdersContext.Orders.AddAsync(orderdetail);//add the record by using addasync
            _companyOrdersContext.SaveChanges();//it will commit/save the data perminently in table
            return 1;
        }

        public async Task<bool> DeleteOrderById(int orderid)
        {
            Orders rm = _companyOrdersContext.Orders.SingleOrDefault(e => e.orderid == orderid);
            if (rm != null)
            {//Here Remove() method is used for removing the data from database.

                _companyOrdersContext.Orders.Remove(rm);
                _companyOrdersContext.SaveChanges();
                return true;
            }
            else return false;
        }

        public async Task<Orders> GetOrderById(int orderid)
        {
            var rm = await _companyOrdersContext.Orders.Where(e => e.orderid == orderid).FirstOrDefaultAsync();

            if (rm == null)
                return null;
            else
                return rm;
        }

        public async Task<List<Orders>> GetOrders()
        {
            var result = _companyOrdersContext.Orders.ToList();
            if (result.Count == 0)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public async  Task<bool> UpdateOrder(Orders orderdetail)
        {
            _companyOrdersContext.Update(orderdetail);
            await _companyOrdersContext.SaveChangesAsync();
            return true;
        }
    }
}
