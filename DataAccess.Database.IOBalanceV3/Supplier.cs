namespace DataAccess.Database.IOBalanceV3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supplier
    {
        public long SupplierID { get; set; }

        [StringLength(16)]
        public string SupplierCode { get; set; }

        [StringLength(128)]
        public string SupplierName { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        public long? UpdatedBy { get; set; }

        public DateTime? DateUpdated { get; set; }

        public bool IsActive { get; set; }
    }
}
