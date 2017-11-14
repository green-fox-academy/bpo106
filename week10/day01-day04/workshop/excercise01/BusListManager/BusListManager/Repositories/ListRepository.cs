using BusListManager.Entities;
using BusListManager.Models;
using System.Linq;

namespace BusListManager.Repositories
{
    public class ListRepository
    {
        public ListContext listContext;

        public ListRepository(ListContext listContext)
        {
            this.listContext = listContext;
        }

        public void AddRow(Bus bus)
        {
            listContext.List.Add(bus);
            listContext.SaveChanges();
        }

        public void RemoveRow(int id)
        {
            listContext.List.Remove(listContext.List.FirstOrDefault(x => x.Id == id));
            listContext.SaveChanges();
        }

        public void UpdateRow(int id, Bus bus)
        {
            foreach (var x in listContext.List.Where(x => x.Id == id))
            {
                x.Id = bus.Id;
                x.Number = bus.Number;
                x.FormerNumber = bus.FormerNumber;
            }
        }
    }
}