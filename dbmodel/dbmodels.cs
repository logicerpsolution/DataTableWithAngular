using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace TodoWeb.dbmodel
{
   

    public class dbmodelsContext : DbContext
    {

        public dbmodelsContext() : base("DefaultConnection")
        {
            if (!this.Database.Exists())
            {
                this.Database.Create();
                RawData.SetInitialData();
            }
        }

        public DbSet<Todo> Todos { get; set; }
    }


    public class RawData {

        public static bool SetInitialData()
        {


            using (dbmodelsContext db = new dbmodelsContext())
            {


                db.Todos.Add(new Todo
                {
                    TodoId=Guid.NewGuid(),
                    IsYesOrNo = "Y",
                    LastRefresh = DateTime.Now,
                    Name = "Todo Text",
                    NameID = 1,
                    PostGradYN = "Y"
                });

                db.Todos.Add(new Todo
                {
                    TodoId = Guid.NewGuid(),
                    IsYesOrNo = "Y",
                    LastRefresh = DateTime.Now,
                    Name = "Todo Text",
                    NameID = 1,
                    PostGradYN = "N"
                });

                return db.SaveChanges() > 0;
            }
            return true;
        }

    }
}