using BusListManager.Entities;

namespace BusListManager.Repositories
{
    public class ListRepository
    {
        public ListContext listContext;

        public ListRepository(ListContext listContext)
        {
            this.listContext = listContext;
        }
    }
}