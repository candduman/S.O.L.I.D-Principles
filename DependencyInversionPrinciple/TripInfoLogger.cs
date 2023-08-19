using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DependencyInversionPrinciple.TripInfoLogger;

namespace DependencyInversionPrinciple
{
    public class TripInfoLogger
    {
        #region Wrong Usage
        public TripInfoLogger()
        {
                
        }
        // So in this class TripInfoLogger is depend to GermanyLogger and LocalStorageLogger.So we need to use abstraction to rule Dependecy Inversion
        public void LogToGermany(string tripInfo)
        {
            new GermanyLogger().Log(tripInfo);
        }
        public void LogToLocalStorage(string tripInfo)
        {
            new LocalStorageLogger().Log(tripInfo);
        }
        #endregion
        // If we need a new logger we dont need to add anything into this class. So bellow usage is correct for dependency Inversion
        #region Right Usage
        private ILogger logger;
        public TripInfoLogger(ILogger _logger)
        {
            logger = _logger;
        }
        public void Log(string logInfo)
        {
            logger.Log(logInfo);
        }
        #endregion
    }
    public interface ILogger
    {
        void Log(string logStr);
    }
    public class GermanyLogger: ILogger
    {
        public void Log(string logStr)
        {
            //process
        }
    }
    public class LocalStorageLogger: ILogger
    {
        public void Log(string logStr)
        {
            //process
        }
    }

    public class EngineException : Exception { }
    public class AirPressureException : Exception { }


}

