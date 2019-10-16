namespace DataAccess.Database.IOBalanceV3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerPrice
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CustomerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ProductID { get; set; }

        public decimal ProductPrice { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        public long? UpdatedBy { get; set; }

        public DateTime? DateUpdated { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}
