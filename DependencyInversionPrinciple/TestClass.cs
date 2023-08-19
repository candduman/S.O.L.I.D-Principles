using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class TestClass
    {
        static void Main(string[] args)
        {

        }
        // when you need a new logger class you need to add method into TripInfoLogger class
        public void SendLogs()
        {
            #region Wrong Usage 
            try
            {
                //process
            }
            catch (EngineException ex)
            {
                new TripInfoLogger().LogToGermany(ex.ToString());
            }
            catch (AirPressureException ex)
            {
                new TripInfoLogger().LogToLocalStorage(ex.ToString());
            }
            #endregion
            #region Right usage
            try
            {
                //process
            }
            catch (EngineException ex)
            {
                new TripInfoLogger(new LocalStorageLogger()).Log(ex.ToString());
            }
            catch (AirPressureException ex)
            {
                new TripInfoLogger(new GermanyLogger()).Log(ex.ToString());
            }
            catch(Exception ex) 
            {
                new TripInfoLogger(new GermanyLogger()).Log(ex.ToString());
                new TripInfoLogger(new LocalStorageLogger()).Log(ex.ToString());
            }
            #endregion
        }
    }
}
