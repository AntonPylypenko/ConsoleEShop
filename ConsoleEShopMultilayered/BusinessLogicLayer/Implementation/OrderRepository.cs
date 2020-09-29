using BusinessLogicLayer.Interfaces;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class OrderRepository : IRepository<Order>
    {
        /// <summary>
        /// This variable returns order.
        /// </summary>
        readonly ListContext _context;

        /// <summary>
        /// Constructor that initializes context with according list.
        /// </summary>
        public OrderRepository()
        {
            _context = new ListContext();
        }

        /// <summary>
        /// This method adds orders to database.
        /// </summary>
        public void Add(Order entity)
        {
            _context.Storage.Orders.Add(entity);
        }

        /// <summary>
        /// This method removes order by ID.
        /// </summary>
        public void Delete(int id)
        {
            _context.Storage.Orders.RemoveAt(id);
        }

        /// <summary>
        /// This method returns order by ID.
        /// </summary>
        public Order GetById(int id)
        {
            return _context.Storage.Orders.FirstOrDefault(o => o.ID == id);
        }

        /// <summary>
        /// This method returns list of orders.
        /// </summary>
        public IEnumerable<Order> GetAllEntities()
        {
            return _context.Storage.Orders;
        }

        /// <summary>
        /// This method changes order ID.
        /// </summary>
        public void ChangeOrderStatus(OrderStatus status, int id)
        {
            _context.Storage.Orders[id].Status = status;
        }
    }
}
