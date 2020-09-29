using System.Collections.Generic;
using BusinessLogicLayer.Interfaces;

namespace BusinessLogicLayer
{  
    public class AccountRepository : IRepository<Account>
    {
        /// <summary>
        /// This variable contains context.
        /// </summary>
        readonly ListContext _context;

        /// <summary>
        /// This method initializes context.
        /// </summary>
        public AccountRepository()
        {
            _context = new ListContext();
        }

        /// <summary>
        /// This method adds account.
        /// </summary>
        public void Add(Account entity)
        {
            _context.Storage.Accounts.Add(entity);
        }

        /// <summary>
        /// This method deletes account by ID.
        /// </summary>
        public void Delete(int id)
        {
            _context.Storage.Accounts.RemoveAt(id);
        }

        /// <summary>
        /// This method returns account by ID.
        /// </summary>
        public Account GetById(int id)
        {
            return _context.Storage.Accounts.FirstOrDefault(o => o.ID == id);
        }

        /// <summary>
        /// This method returns list of account.
        /// </summary>
        public IEnumerable<Account> GetAllEntities()
        {
            return _context.Storage.Accounts;
        }
    }
}
