using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoWeb.dbmodel;

namespace TodoWeb.repository
{
    public class TodoLayer : ITodo
    {
        public List<Todo> GetTodo()
        {
            using (dbmodelsContext db = new dbmodelsContext())
            {
                return db.Database.SqlQuery<Todo>("GetTodoList").ToList();
            }
        }
    }
}