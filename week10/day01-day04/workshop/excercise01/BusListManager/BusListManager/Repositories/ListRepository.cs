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

        public void Id()
        {

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

        public Bus Id(int id)
        {
            return listContext.List.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateRow(Bus bus)
        {
            listContext.List.Update(bus);
            listContext.SaveChanges();
        }
    }
}