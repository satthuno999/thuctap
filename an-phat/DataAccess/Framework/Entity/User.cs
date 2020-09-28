using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Framework.Entity
{
    [Table ("Users")]
    public class User
    {
        public int ID { get; set; }
        public String Email { get; set; }

        public String UserAddress { get; set; }

        public bool PhoneNumber { get; set; }

        public bool Gender { get; set; }

        public string Provice { get; set; }

        public String UserName { get; set; }

    }
}
