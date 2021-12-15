using BackendApp.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BackendApp.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace BackendApp.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly DatabaseContext _dbContext;
        public CustomerService(DatabaseContext dbContext)
        {
           _dbContext = dbContext;
            if (!_dbContext.Customers.Any())
            {
                _dbContext.Customers.Add(new Customer { FirstName = "Віктор", Surname = "Вікторович", LastName = "Прокопенко", Address = "Василенка 21а, 100", City = "Луцьк", Phone = "(063)4569385", CreationTime = (DateTime.Now) - (new TimeSpan(2, 0, 0, 0)) });
                _dbContext.Customers.Add(new Customer { FirstName = "Антон", Surname = "Олегович", LastName = "Крук", Address = "Глибочицька 70", City = "Київ", Phone = "(093)1416433", CreationTime = (DateTime.Now) - (new TimeSpan(5, 0, 0, 0)) });
                _dbContext.Customers.Add(new Customer { FirstName = "Оксана", Surname = "Володимирівна", LastName = "Десятова", Address = "Глибочицька 7а, 22", City = "Київ", Phone = "(068)0989367", CreationTime = (DateTime.Now) - (new TimeSpan(15, 0, 0, 0)) });
                _dbContext.Customers.Add(new Customer { FirstName = "Анна", Surname = "Дмитрівна", LastName = "Шевченко", Address = "Вишнева 15", City = "Харків", Phone = "(098)4569111", CreationTime = (DateTime.Now) - (new TimeSpan(20, 0, 0, 0)) });
                _dbContext.Customers.Add(new Customer { FirstName = "Анатолій", Surname = "Петрович", LastName = "Дідух", Address = "Дружби 10", City = "Суми", Phone = "(068)2229325", CreationTime = (DateTime.Now) - (new TimeSpan(18, 0, 0, 0)) });
                _dbContext.Customers.Add(new Customer { FirstName = "Іван", Surname = "Іванович", LastName = "Тихий", Address = "Крива 54, 17", City = "Полтава", Phone = "(063)1119311", CreationTime = (DateTime.Now) - (new TimeSpan(7, 0, 0, 0)) });
                _dbContext.Customers.Add(new Customer { FirstName = "Віктор", Surname = "Олегович", LastName = "Соловей", Address = "Лісова 11", City = "Херсон", Phone = "(068)4569344", CreationTime = (DateTime.Now) - (new TimeSpan(10, 0, 0, 0)) });
                _dbContext.Customers.Add(new Customer { FirstName = "Ольга", Surname = "Алексїївна", LastName = "Ковтун", Address = "Дорогожицька 77, 99", City = "Одеса", Phone = "(050)4569255", CreationTime = (DateTime.Now) - (new TimeSpan(19, 0, 0, 0)) });
                _dbContext.Customers.Add(new Customer { FirstName = "Аліна", Surname = "Михайлівна", LastName = "Мала", Address = "Науки 20", City = "Миколаїв", Phone = "(050)4539333", CreationTime = (DateTime.Now) - (new TimeSpan(16, 0, 0, 0)) });
                _dbContext.Customers.Add(new Customer { FirstName = "Михайло", Surname = "Андрійович", LastName = "Савка", Address = "Медова 1", City = "Київ", Phone = "(063)9999380", CreationTime = (DateTime.Now) - (new TimeSpan(12, 0, 0, 0)) });
                _dbContext.Customers.Add(new Customer { FirstName = "Артем", Surname = "Іванович", LastName = "Краватка", Address = "Артема 23", City = "Житомир", Phone = "(067)9995558", CreationTime = (DateTime.Now) - (new TimeSpan(8, 0, 0, 0)) });
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Customer> GetCustomers()
        {
            var customer = _dbContext.Customers.ToList();
            return customer;
        }
        public Customer GetCustomerById(int id)
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == id);
            return customer;
        }

        public Customer AddCustomer(Customer customer)
        {
            if (customer != null)
            {
                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();
                return customer;
            }
            return null;
        }
        public Customer UpdateCustomer(Customer customer)
        {
            _dbContext.Entry(customer).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return customer;
        }
        public Customer DeleteCustomer(int id)
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == id);
            _dbContext.Entry(customer).State = EntityState.Deleted;
            _dbContext.SaveChanges();
            return customer;
        }

        /*        public async Task CreateCustomer(Customer customer)
                {
                    await _dbContext.Customers.AddAsync(customer);
                    await _dbContext.SaveChangesAsync();
                }

                public async Task<List<Customer>> ReadCustomers()
                {
                    return await _dbContext.Customers.ToListAsync();
                }

                public async Task<Customer> ReadCustomer(int id)
                {
                    var customer = await _dbContext.Customers.FindAsync(id);
                    if (customer == null)
                    {
                        return NotFound();
                    }
                    return customer;
                }
                public async Task UpdateCustomer(Customer customer)
                {
                    *//*  if (id != customer.Id)
                        {
                           return BadRequest();
                        }*//*
                    _dbContext.Entry(customer).State = EntityState.Modified;
                    await _dbContext.SaveChangesAsync();
        *//*            try
                    {
                        await _dbContext.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CustomerExists(id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return NoContent();*//*
                }
                *//*private bool CustomerExists(int id)
                {
                    return _dbContext.Customers.Any(e => e.Id == id);
                }*//*

                public async Task<Customer> DeleteCustomer(int id)
                {
                    var customer = await _dbContext.Customers.FindAsync(id);
                    if (customer == null)
                    {
                        return NotFound();
                    }

                    _dbContext.Customers.Remove(customer);
                    await _dbContext.SaveChangesAsync();
                    return customer;
                }*/

    }
}
