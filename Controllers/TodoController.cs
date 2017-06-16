using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoWeb.dbmodel;
using System.Web.Http.Cors;
using TodoWeb.repository;

namespace TodoWeb.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class TodoController : ApiController
    {
        private ITodo ITodo;

      public  TodoController(ITodo _ITodo) {

            this.ITodo = _ITodo;
          
        }
        
        public List<Todo> GetTodo()
        {
            return this.ITodo.GetTodo();
        }
    }
}
