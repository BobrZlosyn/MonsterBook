using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class TodoListModul
    {
        private int lastUsedId;
        private List<TodoItem> todoList;

        public TodoListModul ()
        {
            ///TODO: nacitani ID z databaze - presunout do projektu databaze
            lastUsedId = 0;
            todoList = new List<TodoItem>();
        }

        public void LoadItems()
        {

        }

        public void SynchronizeItems()
        {

        }


        public void CreateNewTodo(string title, string msg, int category, DateTime start, DateTime end)
        {
            TodoItem todo = new TodoItem()
            {
                ID = lastUsedId++,
                Title = title,
                Message = msg,
                Category = category,
                StartTime = start,
                FinnishTime = end,
                CreatedTime = DateTime.Now,
            };

            ///save to database or putaway until reconnection
            todoList.Add(todo);
        }

        public void EditTodo(int ID, string title, string msg, int category, DateTime start, DateTime end)
        {
            TodoItem item = GetTodoByID(ID);
            item.Title = title;
            item.Message = msg;
            item.Category = category;
            item.StartTime = start;
            item.FinnishTime = end;
        }

        public TodoItem GetTodoByID (int ID)
        {
            foreach (var todo in todoList)
            {
                if (todo.ID == ID )
                {
                    return todo;
                }
            }
            return null;
        }

        public void PrintList ()
        {
            foreach (var todo in todoList)
            {
                Console.WriteLine($"{todo.Title}\t" +
                    $"{todo.Message}\t" +
                    $"{todo.StartTime}\t" +
                    $"{todo.FinnishTime}\t" +
                    $"{todo.CreatedTime}\t" +
                    $"{todo.Category}\t" +
                    $"{todo.ID}");
            }
        }
    }
}
