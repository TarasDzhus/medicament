using BackendApp.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BackendApp.Interfaces;
using System.Linq;
using System;

namespace BackendApp.Services
{
    public class OrderService : IOrderService
    {
        private readonly DatabaseContext _dbContext;
        public OrderService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            if (!_dbContext.Orders.Any())
            {
                _dbContext.Orders.Add(new Order { CustomerId = 1, EmployeeId = 3, OrderDate = (DateTime.Now) - (new TimeSpan(0, 20, 0, 0)), MedicamentId = 1, Qty = 1, Price = 295 });
                _dbContext.Orders.Add(new Order { CustomerId = 2, EmployeeId = 6, OrderDate = (DateTime.Now) - (new TimeSpan(0, 10, 0, 0)), MedicamentId = 2, Qty = 1, Price = 445 });
                _dbContext.Orders.Add(new Order { CustomerId = 3, EmployeeId = 4, OrderDate = (DateTime.Now) - (new TimeSpan(0, 5, 0, 0)), MedicamentId = 6, Qty = 1, Price = 450 });
                _dbContext.Orders.Add(new Order { CustomerId = 3, EmployeeId = 1, OrderDate = (DateTime.Now) - (new TimeSpan(0, 1, 0, 0)), MedicamentId = 4, Qty = 1, Price = 422 });
                _dbContext.Orders.Add(new Order { CustomerId = 2, EmployeeId = 3, OrderDate = (DateTime.Now) - (new TimeSpan(0, 4, 0, 0)), MedicamentId = 9, Qty = 4, Price = 218 });
                _dbContext.Orders.Add(new Order { CustomerId = 4, EmployeeId = 6, OrderDate = (DateTime.Now) - (new TimeSpan(0, 6, 0, 0)), MedicamentId = 7, Qty = 1, Price = 450 });
                _dbContext.Orders.Add(new Order { CustomerId = 1, EmployeeId = 3, OrderDate = (DateTime.Now) - (new TimeSpan(0, 22, 0, 0)), MedicamentId = 9, Qty = 1, Price = 220 });
                _dbContext.Orders.Add(new Order { CustomerId = 5, EmployeeId = 3, OrderDate = (DateTime.Now) - (new TimeSpan(0, 12, 0, 0)), MedicamentId = 8, Qty = 1, Price = 550 });
                _dbContext.Orders.Add(new Order { CustomerId = 6, EmployeeId = 3, OrderDate = (DateTime.Now) - (new TimeSpan(0, 9, 0, 0)), MedicamentId = 8, Qty = 2, Price = 550 });
                _dbContext.Orders.Add(new Order { CustomerId = 1, EmployeeId = 4, OrderDate = (DateTime.Now) - (new TimeSpan(0, 8, 0, 0)), MedicamentId = 9, Qty = 1, Price = 222 });
                _dbContext.Orders.Add(new Order { CustomerId = 2, EmployeeId = 1, OrderDate = (DateTime.Now) - (new TimeSpan(0, 14, 0, 0)), MedicamentId = 5, Qty = 1, Price = 289 });
                _dbContext.Orders.Add(new Order { CustomerId = 7, EmployeeId = 3, OrderDate = (DateTime.Now) - (new TimeSpan(0, 3, 0, 0)), MedicamentId = 3, Qty = 1, Price = 518 });
                _dbContext.Orders.Add(new Order { CustomerId = 6, EmployeeId = 4, OrderDate = (DateTime.Now) - (new TimeSpan(0, 1, 0, 0)), MedicamentId = 9, Qty = 1, Price = 220 });
                _dbContext.Orders.Add(new Order { CustomerId = 3, EmployeeId = 1, OrderDate = (DateTime.Now) - (new TimeSpan(0, 6, 0, 0)), MedicamentId = 6, Qty = 1, Price = 451 });
                _dbContext.Orders.Add(new Order { CustomerId = 5, EmployeeId = 6, OrderDate = (DateTime.Now) - (new TimeSpan(0, 9, 0, 0)), MedicamentId = 10, Qty = 1, Price = 600 });
                _dbContext.Orders.Add(new Order { CustomerId = 8, EmployeeId = 3, OrderDate = (DateTime.Now) - (new TimeSpan(0, 11, 0, 0)), MedicamentId = 10, Qty = 2, Price = 600 });
                _dbContext.Orders.Add(new Order { CustomerId = 5, EmployeeId = 4, OrderDate = (DateTime.Now) - (new TimeSpan(0, 10, 0, 0)), MedicamentId = 7, Qty = 2, Price = 452 });
                _dbContext.Orders.Add(new Order { CustomerId = 7, EmployeeId = 4, OrderDate = (DateTime.Now) - (new TimeSpan(0, 20, 0, 0)), MedicamentId = 9, Qty = 1, Price = 220 });
                _dbContext.Orders.Add(new Order { CustomerId = 7, EmployeeId = 3, OrderDate = (DateTime.Now) - (new TimeSpan(0, 11, 0, 0)), MedicamentId = 2, Qty = 1, Price = 450 }); 
                _dbContext.Orders.Add(new Order { CustomerId = 9, EmployeeId = 3, OrderDate = (DateTime.Now) - (new TimeSpan(0, 7, 0, 0)), MedicamentId = 3, Qty = 1, Price = 525 });
                _dbContext.Orders.Add(new Order { CustomerId = 8, EmployeeId = 4, OrderDate = (DateTime.Now) - (new TimeSpan(0, 2, 0, 0)), MedicamentId = 4, Qty = 2, Price = 420 });
                _dbContext.Orders.Add(new Order { CustomerId = 10, EmployeeId = 1, OrderDate = (DateTime.Now) - (new TimeSpan(0, 18, 0, 0)), MedicamentId = 6, Qty = 4, Price = 450 });
                _dbContext.Orders.Add(new Order { CustomerId = 11, EmployeeId = 3, OrderDate = (DateTime.Now) - (new TimeSpan(0, 16, 0, 0)), MedicamentId = 7, Qty = 3, Price = 100 });
                _dbContext.Orders.Add(new Order { CustomerId = 10, EmployeeId = 4, OrderDate = (DateTime.Now) - (new TimeSpan(0, 12, 0, 0)), MedicamentId = 2, Qty = 5, Price = 200 });
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Order> GetOrder()
        {
            var order = _dbContext.Orders.ToList();
            return order;
        }
        public Order GetOrderById(int id)
        {
            var order = _dbContext.Orders.FirstOrDefault(x => x.Id == id);
            return order;
        }

        public Order AddOrder(Order order)
        {
            if (order != null)
            {
                _dbContext.Orders.Add(order);
                _dbContext.SaveChanges();
                return order;
            }
            return null;
        }
        public Order UpdateOrder(Order order)
        {
            _dbContext.Entry(order).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return order;
        }
        public Order DeleteOrder(int id)
        {
            var order = _dbContext.Orders.FirstOrDefault(x => x.Id == id);
            _dbContext.Entry(order).State = EntityState.Deleted;
            _dbContext.SaveChanges();
            return order;
        }

        /*        public async Task CreateOrder(Order order)
                {
                    await _dbContext.Orders.AddAsync(order);
                    await _dbContext.SaveChangesAsync();
                }

                public async Task<List<Order>> ReadOrders()
                {
                    return await _dbContext.Orders.ToListAsync();
                }

                public async Task<Order> ReadOrder(int id)
                {
                    var order = await _dbContext.Orders.FindAsync(id);
                    if (order == null)
                    {
                        return NotFound();
                    }
                    return order;
                }

                public async Task UpdateOrder(Order order)
                {
                    _dbContext.Entry(order).State = EntityState.Modified;
                    await _dbContext.SaveChangesAsync();
                }

                public async Task<Order> DeleteOrder(int id)
                {
                    var order = await _dbContext.Orders.FindAsync(id);
                    if (order == null)
                    {
                        return NotFound();
                    }
                    _dbContext.Orders.Remove(order);
                    await _dbContext.SaveChangesAsync();
                    return order;
                }*/
    }
}
