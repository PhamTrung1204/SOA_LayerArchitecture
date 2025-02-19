using LayerArchitecture.Database.Models;
using LayerArchitecture.Persistence;
using System.Collections.Generic;

namespace LayerArchitecture.Business
{
    public class CustomerService
    {
        private readonly CustomerDAO _customerDAO;
        public CustomerService(CustomerDAO customerDAO)
        {
            _customerDAO = customerDAO;
        }

        public List<Customer> GetCustomers() => _customerDAO.GetAllCustomers();
        public Customer? GetCustomer(int id) => _customerDAO.GetCustomerById(id);
        public void AddCustomer(Customer customer) => _customerDAO.AddCustomer(customer);
        public void UpdateCustomer(Customer customer) => _customerDAO.UpdateCustomer(customer);
        public void DeleteCustomer(int id) => _customerDAO.DeleteCustomer(id);
    }
}
