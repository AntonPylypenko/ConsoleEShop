using DataAccessLayer.DataStorage;

namespace DataAccessLayer.Context
{
    public class ListContext
    {
        public ListStorage Storage { get; set; }
        public ListContext()
        {
            Storage = new ListStorage();
        }
    }
}
