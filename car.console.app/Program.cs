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
            #region car

            Car car1 = new Car("Kia", "Optima", 70, 50, 12);
            Car car2 = new Car("Hyundai", "Elantra", 60, 40, 8);
            Car car3 = new Car("Bmw", "M5", 100, 80, 25);
            Car car4 = new Car("Mercedes", "s class", 120, 90, 35);
            Console.WriteLine("                                                       WELCOME TO APP ");
            int CarName = 0;
            decimal user = 0;
            Console.WriteLine("");
            do
            {
                Console.WriteLine(">>>>> Choose the Car <<<<<");
                Console.WriteLine("");
                Console.WriteLine("1.Kia Optima");
                Console.WriteLine("2.Hyundai Elantra");
                Console.WriteLine("3.Bmw M5");
                Console.WriteLine("4.Mercedes s class");
                Console.Write(">>>>> ");
                CarName = Convert.ToInt32(Console.ReadLine());
               
                do
                {
                    Console.WriteLine("1.Go");
                    Console.WriteLine("2.TopUp");
                    Console.WriteLine("3.Stop");
                    Console.WriteLine("4.Reset");
                    Console.WriteLine("5.Exit");
                    Console.Write(">>>>> ");

                    switch (CarName)
                    {
                        case 1:
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
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine(">>>>> Please, Enter number between 1 and 5. <<<<<");
                                    break;
                            }
                            break;
                        case 2:
                            user = Convert.ToDecimal(Console.ReadLine());
                            switch (user)
                            {
                                case 1:
                                    car2.Go();
                                    break;
                                case 2:
                                    car2.TopUp();
                                    break;
                                case 3:
                                    car2.Stop();
                                    break;
                                case 4:
                                    car2.Reset();
                                    break;
                                case 5:
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine(">>>>> Please, Enter number between 1 and 5. <<<<<");
                                    break;
                            }
                            break;
                        case 3:
                            user = Convert.ToDecimal(Console.ReadLine());
                            switch (user)
                            {
                                case 1:
                                    car3.Go();
                                    break;
                                case 2:
                                    car3.TopUp();
                                    break;
                                case 3:
                                    car3.Stop();
                                    break;
                                case 4:
                                    car3.Reset();
                                    break;
                                case 5:
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine(">>>>> Please, Enter number between 1 and 5. <<<<<");
                                    break;
                            }
                            break;
                        case 4:
                            user = Convert.ToDecimal(Console.ReadLine());
                            switch (user)
                            {
                                case 1:
                                    car4.Go();
                                    break;
                                case 2:
                                    car4.TopUp();
                                    break;
                                case 3:
                                    car4.Stop();
                                    break;
                                case 4:
                                    car4.Reset();
                                    break;
                                case 5:
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine(">>>>> Please, Enter number between 1 and 5. <<<<<");
                                   break;
                            }
                            break;
                        default:
                            Console.WriteLine(">>>>> Please, Enter number between 1 and 4. <<<<<");
                            break;
                    }
                   
                } while (user != 5); 
               

            } while (CarName !=4);

            
           
            

            Console.Read();

            #endregion

        }
    }
}
