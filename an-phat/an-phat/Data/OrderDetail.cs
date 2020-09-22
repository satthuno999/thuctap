namespace an_phat.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? OrderID { get; set; }

        public int? ProductID { get; set; }

        public decimal? SellPrice { get; set; }

        public decimal? SellDiscount { get; set; }

        public virtual User User { get; set; }

        public virtual Product Product { get; set; }
    }
}
