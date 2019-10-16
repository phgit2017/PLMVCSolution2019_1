using IOBalanceDBV3Entity = DataAccess.Database.IOBalanceV3;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IOBalanceV3.Interface
{
    public interface ILoggerDataServices <T>
    {
       T SaveLog(T item,
           T oldItem,
           IOBalanceDBV3Entity.Loggers loggers,
           List<string> columnNames);
    }
}
