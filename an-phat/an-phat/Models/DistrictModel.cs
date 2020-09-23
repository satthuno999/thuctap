using an_phat.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace an_phat.Models
{
    public class DistrictModel
    {
        public SelectList DistrictCollection { get; set; }

        public string NameDistrict { get; set; }

        public int ID { get; set; }

       
    }
    
}