using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IOBalanceV3.Dto
{
    public class FilePasswordDetails : CommonDetails
    {
        public long FilePasswordId { get; set; }
        public string FilePassword { get; set; }
    }
}
