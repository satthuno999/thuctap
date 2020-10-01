using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Framework.Entity
{
    [Table("ProductProperty")]
    public class ProductProperty
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int PropertyID { get; set; }
        public string PropertyValue { get; set; }

    }
}
