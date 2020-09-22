namespace an_phat.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductImage")]
    public partial class ProductImage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ProductID { get; set; }

        public int? ImageID { get; set; }

        public byte? ImageType { get; set; }

        public virtual Image Image { get; set; }

        public virtual Product Product { get; set; }
    }
}
