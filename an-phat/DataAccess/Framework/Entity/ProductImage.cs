using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Framework.Entity
{
    [Table("ProductImage")]
    public class ProductImage
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int ImageID { get; set; }
        public byte ImageType { get; set; }
    }
}
