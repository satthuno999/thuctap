using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Framework.Entity
{
    [Table("ProductCategory")]
    public class ProductCategory
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
    }
}
