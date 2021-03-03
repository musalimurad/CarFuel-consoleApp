using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car.console.app
{
    static class Utilities
    {
        public static bool IsNumber(string text)
        {
            try
            {
                Convert.ToDecimal(text);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine(">>>>> Please, Enter only number!!!! <<<<<");
                return false;
            }
        }
    }
}
