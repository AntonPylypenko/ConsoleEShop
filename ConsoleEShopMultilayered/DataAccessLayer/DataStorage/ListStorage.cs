using DataAccessLayer.Models;
using System.Collections.Generic;

namespace DataAccessLayer.DataStorage
{
    public class ListStorage
    {
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Account> Accounts { get; set; } = new List<Account>();
        public List<Commodity> Commodities { get; set; } = new List<Commodity>();
    }
}
