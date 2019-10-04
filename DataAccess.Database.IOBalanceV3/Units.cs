using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Database.IOBalanceV3
{
    public class Units
    {
        [Key]
        public long UnitID { get; set; }
        public string UnitDescription { get; set; }
    }
}
