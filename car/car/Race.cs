using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class Race
    {

        Car _PlayerOne;
        Car _PlayerTwo;

        int MoneyForWin;

        public Race()
        {
            Random rand = new Random();
            int cars = rand.Next(1,5);


            _PlayerTwo = CarList.AddCarListList()[cars];

            int start_money = 100;

            MoneyForWin = start_money * cars;
        }
    }
}
