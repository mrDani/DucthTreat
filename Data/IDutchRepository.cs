using DutchTreat.Data.Entities;
using System;
using System.Collections.Generic;

namespace DucthTreat.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);

        IEnumerable<Order> GetAllOrders(bool includeItems);
        IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems);
        Order GetOrderById(string username,int id);

        bool SaveChanges();

        bool SaveAll();
        void AddEntity(object model);
    }
}