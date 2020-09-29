using DataAccessLayer.Interface;
using System;

namespace DataAccessLayer.Models
{

    public class Order : IHaveID
    {
        public int ID { get; set; }
        public Account Account { get; set; }
        public Commodity Commodity { get; set; }
        public OrderStatuses Status { get; set; }
        public DateTime Date { get; set; }

        public Order(int id, Account account, Commodity commodity, OrderStatuses status)
        {
            ID = id;
            Account = account;
            Commodity = commodity;
            Status = status;
            Date = DateTime.Now;
        }
    }

    public enum OrderStatuses
    {
        New,
        CanceledByAdmin,
        CanceledByUser,
        Dispatched,
        Received,
        PaymentIsReceived,
        Finished
    }
}
