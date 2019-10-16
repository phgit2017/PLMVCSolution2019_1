using Business.IOBalanceV3.Interface;
using DataAccess.Database.IOBalanceV3;
using DataAccess.Repository.PL;
using IOBalanceDBV3Entity = DataAccess.Database.IOBalanceV3;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IOBalanceV3
{
    public partial class LoggerDataServices<T> : ILoggerDataServices<T> where T : class
    {
        PLRepository<Loggers> _loggers;
        
        public LoggerDataServices(PLRepository<Loggers> loggers)
        {
            this._loggers = loggers;
        }

        public T SaveLog(T item, 
            T oldItem,
            IOBalanceDBV3Entity.Loggers loggers,
            List<string> columnNames)
        {
            object aa = typeof(T).GetType();
            foreach (var col in columnNames)
            {

            }
            this._loggers.Insert(loggers);
            return item;
        }
    }
}
