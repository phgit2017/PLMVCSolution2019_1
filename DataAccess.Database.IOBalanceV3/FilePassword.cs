﻿namespace DataAccess.Database.IOBalanceV3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FilePassword
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long FilePasswordID { get; set; }

        [Column("FilePassword")]
        [Required]
        [StringLength(128)]
        public string FilePasswordName { get; set; }

        public DateTime? DateCreated { get; set; }

        public long? CreatedBy { get; set; }
    }
}
