using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TodoWeb.dbmodel
{
    public class Todo
    {
        [Key]
        public Guid TodoId { get; set; }
        public DateTime LastRefresh { get; set; }

        public int NameID { get; set; }

        public string Name { get; set; }

        public string IsYesOrNo { get; set; }

        public string PostGradYN { get; set; }

    }
}