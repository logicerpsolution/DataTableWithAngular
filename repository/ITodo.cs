using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoWeb.dbmodel;

namespace TodoWeb.repository
{
  public  interface ITodo
    {
        List<Todo> GetTodo();
    
    }
}
