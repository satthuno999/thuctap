namespace an_phat.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductProperty")]
    public partial class ProductProperty
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ProductID { get; set; }

        public int? PropertyID { get; set; }

        [StringLength(250)]
        public string PropertyValue { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Product Product { get; set; }

        public virtual PropertyCategory PropertyCategory { get; set; }
    }
}
