using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Entities;
using TodoApp.Models;

namespace TodoApp.Repositories
{
    public class TodoRepository
    {
        public Context context;

        public TodoRepository(Context context)
        {
            this.context = context;
        }

        public void AddRow(Todo todo)
        {
            context.Todos.Add(todo);
            context.SaveChanges();
        }

        public void RemoveRow(int id)
        {
            context.Todos.Remove(context.Todos.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }
    }
}
