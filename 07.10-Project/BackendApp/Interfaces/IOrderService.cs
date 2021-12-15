using BackendApp.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BackendApp.Interfaces
{
    public interface IOrderService
    {
        public IEnumerable<Order> GetOrder();
        public Order GetOrderById(int id);
        public Order AddOrder(Order order);
        public Order UpdateOrder(Order order);
        public Order DeleteOrder(int id);

        /*public Task CreateOrder(Order order);
        public Task <List<Order>> ReadOrders();
        public Task<Order> ReadOrder(int id);
        public Task UpdateOrder(Order order);
        public Task<Order> DeleteOrder(int id);
        IEnumerable<Order> GetOrder();*/
    }
}
