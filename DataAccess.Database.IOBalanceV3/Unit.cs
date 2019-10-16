namespace DataAccess.Database.IOBalanceV3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Unit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UnitID { get; set; }

        [StringLength(16)]
        public string UnitDescription { get; set; }
    }
}
