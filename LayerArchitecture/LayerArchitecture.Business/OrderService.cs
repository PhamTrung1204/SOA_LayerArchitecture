using LayerArchitecture.Database.Models;
using LayerArchitecture.Persistence;
using System.Collections.Generic;

namespace LayerArchitecture.Business
{
    public class OrderService
    {
        private readonly OrderDAO _orderDAO;
        public OrderService(OrderDAO orderDAO)
        {
            _orderDAO = orderDAO;
        }

        public List<Order> GetOrders() => _orderDAO.GetAllOrders();
        public Order? GetOrder(int id) => _orderDAO.GetOrderById(id);
        public void AddOrder(Order order) => _orderDAO.AddOrder(order);
        public void UpdateOrder(Order order) => _orderDAO.UpdateOrder(order);
        public void DeleteOrder(int id) => _orderDAO.DeleteOrder(id);
    }
}
