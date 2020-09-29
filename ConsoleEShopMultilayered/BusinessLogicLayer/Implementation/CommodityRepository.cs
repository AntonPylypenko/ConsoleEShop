using BusinessLogicLayer.Interfaces;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class CommodityRepository : IRepository<Commodity>
    {
        /// <summary>
        /// This variable contains context.
        /// </summary>
        readonly ListContext _context;

        /// <summary>
        /// This method initializes context.
        /// </summary>
        public CommodityRepository()
        {
            _context = new ListContext();
        }

        /// <summary>
        /// This method adds commodity.
        /// </summary>
        public void Add(Commodity entity)
        {
            _context.Storage.Commodities.Add(entity);
        }

        /// <summary>
        /// This method deletes entity by ID.
        /// </summary>
        public void Delete(int id)
        {
            _context.Storage.Commodities.RemoveAt(id);
        }

        /// <summary>
        /// This method returns commodity by ID.
        /// </summary>
        public Commodity GetById(int id)
        {
            return _context.Storage.Commodities.FirstOrDefault(o => o.ID == id);
        }

        /// <summary>
        /// This method returns list of commodities.
        /// </summary>
        public IEnumerable<Commodity> GetAllEntities()
        {
            return _context.Storage.Commodities;
        }
    }
}
