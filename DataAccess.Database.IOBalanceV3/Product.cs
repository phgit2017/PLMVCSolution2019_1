namespace DataAccess.Database.IOBalanceV3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public Product()
        {
            CustomerPrices = new HashSet<CustomerPrice>();
        }

        public long ProductID { get; set; }

        [StringLength(64)]
        public string ProductCode { get; set; }

        [StringLength(256)]
        public string ProductDescription { get; set; }

        [StringLength(256)]
        public string ProductExtension { get; set; }

        public decimal ProductQuantity { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        public long? UpdatedBy { get; set; }

        public DateTime? DateUpdated { get; set; }

        public virtual ICollection<CustomerPrice> CustomerPrices { get; set; }
    }
}
