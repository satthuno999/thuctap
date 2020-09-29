using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Framework.Entity
{
    [Table("Images")]
    public class Image
    {
        public int ID { get; set; }
        public string Url { get; set; }
    }
}
