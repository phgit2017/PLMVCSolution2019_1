using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IOBalanceV3.Dto
{
    public class CommonDetails
    {
        public long? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsActive { get; set; }
    }
}
