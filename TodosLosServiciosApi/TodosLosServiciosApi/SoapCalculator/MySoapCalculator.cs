using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodosLosServiciosApi
{
    public class MySoapCalculator : IMySoapCalculator
    {
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