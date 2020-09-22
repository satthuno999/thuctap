namespace an_phat.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(50)]
        public string ShipAddress { get; set; }

        public int? Phone { get; set; }

        public DateTime? OrderDate { get; set; }

        public double? OrderTotal { get; set; }

        [StringLength(100)]
        public string OrderStatus { get; set; }

        public virtual User User { get; set; }
    }
}
