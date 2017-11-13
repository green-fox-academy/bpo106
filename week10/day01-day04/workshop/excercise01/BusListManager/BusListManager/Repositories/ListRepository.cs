using BusListManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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