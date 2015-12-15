using System;

namespace TodosLosServiciosApi
{
    public class MyCalculator : IMySoapCalculator, IMyRestCalculator
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