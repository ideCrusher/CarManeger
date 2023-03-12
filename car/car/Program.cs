using System;
using System.Collections.Generic;

namespace car
{
    internal class Program
    {
        static Car myCar = CarList.RareCar;
        static void Main(string[] args)
        {
            int p = 0;
            while (p < 1)
            {
                Console.WriteLine("Введите команду.");
                string s = Console.ReadLine();
                if(s == "-Get_Car")
                {
                    myCar.Get_Car();
                }               
            }
        }

        static void Starter()
        {

        }
    }
}
