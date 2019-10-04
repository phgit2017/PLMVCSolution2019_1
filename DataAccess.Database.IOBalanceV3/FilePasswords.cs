using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Database.IOBalanceV3
{
    public class FilePasswords
    {
        [Key]
        public long FilePasswordID { get; set; }
        public string FilePassword { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
