using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Framework.Entity
{
    [Table ("District")]
    public class District
    {
        public int ID { get; set; }
        public String NameDistrict { get; set; }

    }
}
