using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Framework.Entity
{
    [Table("Products")]
    public class Product
    {
        public int ID { get; set; }
        public int Code { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public string DescriptionProduct { get; set; }
    }
}
