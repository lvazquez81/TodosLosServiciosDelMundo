using System;
 
namespace TodosLosServiciosApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MyCalculatorService : IMySoapCalculator, IMyRestCalculator
    {
        public int AddRest(string Number1, string Number2)
        {
            return Convert.ToInt32(Number1) + Convert.ToInt32(Number2);
        }

        public int DivRest(string Number1, string Number2)
        {
            return Convert.ToInt32(Number1) / Convert.ToInt32(Number2);
        }

        public int MulRest(string Number1, string Number2)
        {
            return Convert.ToInt32(Number1) * Convert.ToInt32(Number2);
        }

        public int SubRest(string Number1, string Number2)
        {
            return Convert.ToInt32(Number1) - Convert.ToInt32(Number2);
        }

        public int Add(int Number1, int Number2)
        {
            return Number1 + Number2;
        }

        public int Div(int Number1, int Number2)
        {
            return Number1 / Number2;
        }

        public int Mul(int Number1, int Number2)
        {
            return Number1 * Number2;
        }

        public int Sub(int Number1, int Number2)
        {
            return Number1 - Number2;
        }
    }
}
