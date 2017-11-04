using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Entities;

namespace TodoApp.Repositories
{
    public class TodoRepository
    {
        public Context context;

        public TodoRepository(Context context)
        {
            this.context = context;
        }

        public void AddRow()
        {

        }

        public void RemoveRow()
        {

        }
    }
}
