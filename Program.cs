using System;


namespace log4netAdvanced
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            // create 2 persons
            var person1 = new Person("Jonh", "Gold");
            var person2 = new Person("James", "Miller");

            // create 2 cars
            var car1 = new Car("Tesla Model S", 2020, person1);
            var car2 = new Car("Tesla Model X", 2020, person2);

            // logging
            log.Debug("Some debug log");
            log.Info(String.Format("Person1: {0}", person1));
            log.Info(String.Format("Car2: {0}", car2));
            log.Warn(String.Format("Warning accrued at {0}", DateTime.Now));
            log.Error(String.Format("Error accrued at {0}", DateTime.Now));
            log.Fatal(String.Format("Serious problem with car {0} accrued at {1}", car1, DateTime.Now));

            // Division por cero
            var i = 0;

            try
            {
                var x = 10 / i;
            }
            catch (DivideByZeroException ex)
            {
                log.Error("Developer: we tried to divide by zero again", ex);
            }

        }
    }
}
