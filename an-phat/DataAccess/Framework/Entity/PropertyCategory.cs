using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Framework.Entity
{
    [Table("PropertyCategory")]
    public class PropertyCategory
    {
        public int ID { get; set; }
        public string PropertyName { get; set; }
        public int ParentID { get; set; }
        public byte PriorityType { get; set; }
        public int CategoryID { get; set; }

    }
}
