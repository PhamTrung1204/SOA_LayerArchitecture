using LayerArchitecture.Database;
using LayerArchitecture.Database.Models;
using System.Collections.Generic;
using System.Linq;

namespace LayerArchitecture.Persistence
{
    public class OrderDAO
    {
        private readonly AppDbContext _context;
        public OrderDAO(AppDbContext context)
        {
            _context = context;
        }

        public List<Order> GetAllOrders() => _context.Orders.ToList();
        public Order? GetOrderById(int id) => _context.Orders.Find(id);
        public void AddOrder(Order order) { _context.Orders.Add(order); _context.SaveChanges(); }
        public void UpdateOrder(Order order) { _context.Orders.Update(order); _context.SaveChanges(); }
        public void DeleteOrder(int id) { var order = _context.Orders.Find(id); if (order != null) { _context.Orders.Remove(order); _context.SaveChanges(); } }
    }
}
