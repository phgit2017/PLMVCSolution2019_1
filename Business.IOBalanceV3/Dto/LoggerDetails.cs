using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IOBalanceV3.Dto
{
    public class LoggerDetails : CommonDetails
    {
        public long LoggerId { get; set; }

        [StringLength(64)]
        public string ColumnName { get; set; }

        [StringLength(1000)]
        public string OldValue { get; set; }

        [StringLength(1000)]
        public string NewValue { get; set; }

        [StringLength(64)]
        public string LoggingMethod { get; set; }
    }
}
