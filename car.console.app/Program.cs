using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car.console.app
{
    class Program
    {
        static void Main(string[] args)
        {
            #region car1

            Car car1 = new Car("Kia", "Optima", 70, 50);
            Console.WriteLine(">>>>> Welcome To App <<<<<");
            decimal user =0;
           
            do
            {
                Console.WriteLine("1.Go");
                Console.WriteLine("2.TopUp");
                Console.WriteLine("3.Stop");
                Console.WriteLine("4.Reset");
                Console.WriteLine("5.GlobalKm");
                Console.WriteLine("6.Exit");
                Console.Write(">>>>> ");
                user = Convert.ToDecimal(Console.ReadLine());
                switch (user)
                {
                    case 1:
                        car1.Go();
                        break;
                    case 2:
                        car1.TopUp();
                        break;
                    case 3:
                        car1.Stop();
                        break;
                    case 4:
                        car1.Reset();
                        break;
                    case 5:
                        car1.Probeg();
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine(">>>>> Please, Enter number between 1 and 6. <<<<<");
                        break;
                }
            } while (user != 6);
            Console.Read();

            #endregion

        }
    }
}
