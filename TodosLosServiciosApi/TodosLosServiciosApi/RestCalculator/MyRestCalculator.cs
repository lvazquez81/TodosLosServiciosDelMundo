using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodosLosServiciosApi
{
    public class MyRestCalculator : IMyRestCalculator
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
    }
}