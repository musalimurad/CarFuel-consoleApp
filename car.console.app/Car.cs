using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace car.console.app
{
    class Car
    {
        #region Property
        public string Mark;
        public string Model;
        public decimal MaxFuel;
        public decimal CurrentFuel;
        private decimal FuelEffect;
        private decimal LocalKm=0;

        #endregion
        public Car()
        {

        }

        #region Car constructor
        public Car(string Mark, string Model, decimal MaxFuel, decimal CurrentFuel, decimal FuelEffect)
        {
            this.Mark = Mark;
            this.Model = Model;
            this.MaxFuel = MaxFuel;
            this.CurrentFuel = CurrentFuel;
            this.FuelEffect = FuelEffect;
        }
        //constructor   
        #endregion

        #region Go Method
        public void Go()
        {
            decimal b = -1;

            while (b == -1)
            {
                Console.WriteLine(">>>>> How many km do you want to go? <<<<<");
                Console.Write(">>>>> ");
                string neededKm = Console.ReadLine();
                decimal neededLt;
                if (Utilities.IsNumber(neededKm))
                {
                    decimal needIntKm = Convert.ToDecimal(neededKm);
                    if (CurrentFuel > needIntKm / 100 * FuelEffect)
                    {
                        CurrentFuel -= needIntKm / 100 * FuelEffect;
                        Console.WriteLine($">>>>> If you drive {needIntKm} , you will remain {CurrentFuel} lt fuel. <<<<<");
                        b = needIntKm;
                        LocalKm += needIntKm;
                    }
                    else
                    {
                        neededLt = CurrentFuel - needIntKm / 100 * FuelEffect;
                        Console.WriteLine($">>>>> Sorry, Not enough fuel. You need {neededLt} lt fuel!!! <<<<<");
                    }
                }
            }
        }
        #endregion

        #region TopUp Method
        public void TopUp()
        {
            decimal a = -1;
            while (a==-1)
            {
                Console.WriteLine(">>>>> How much lt fuel do you want to fill up? <<<<<");
                Console.Write(">>>>> ");
                string neededFuel = Console.ReadLine();

                if (Utilities.IsNumber(neededFuel))
                {
                    decimal fuelDec = Convert.ToDecimal(neededFuel);
                    if (MaxFuel >= CurrentFuel + fuelDec)
                    {
                        CurrentFuel += fuelDec;
                        Console.WriteLine($">>>>> Good way! Your current fuel: {CurrentFuel} lt <<<<<");
                        a = fuelDec;
                    }
                    else
                    {
                        Console.WriteLine($">>>>> You can't fill up {fuelDec} lt fuel. You have {CurrentFuel} lt fuel. Your max fuel is {MaxFuel} lt <<<<<");
                    }
                }
            }
          
        }
        #endregion

        #region Stop Method
        public void Stop()
        {
            Console.WriteLine($">>>>> Local km: {LocalKm} km, Current fuel: {CurrentFuel} lt. <<<<<");
        }
        #endregion

        #region Reset Method
        public void Reset()
        {
            LocalKm = 0;
            Console.WriteLine($">>>>> LocalKm:{LocalKm} <<<<<");
        }
        #endregion

       
    }


}
