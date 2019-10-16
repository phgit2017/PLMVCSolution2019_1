namespace DataAccess.Database.IOBalanceV3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Loggers")]
    public class Loggers
    {
        public long LoggerID { get; set; }

        [StringLength(64)]
        public string ColumnName { get; set; }

        [StringLength(1000)]
        public string OldValue { get; set; }

        [StringLength(1000)]
        public string NewValue { get; set; }

        [StringLength(64)]
        public string LoggingMethod { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
