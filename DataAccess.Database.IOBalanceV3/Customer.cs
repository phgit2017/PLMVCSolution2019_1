namespace DataAccess.Database.IOBalanceV3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers")]
    public class Customer
    {
        public Customer()
        {
            CustomerPrices = new HashSet<CustomerPrice>();
        }

        public long CustomerID { get; set; }

        [StringLength(32)]
        public string CustomerCode { get; set; }

        [StringLength(256)]
        public string CustomerName { get; set; }

        [StringLength(800)]
        public string CustomerAddress { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        public long? UpdatedBy { get; set; }

        public DateTime? DateUpdated { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<CustomerPrice> CustomerPrices { get; set; }
    }
}
