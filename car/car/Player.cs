using System;
using System.IO;

namespace car
{
    public class Player
    {
        string _Name;

        Car _PlayerCar;

        double _Money;

        int _WinCount, _LossCount;

        int _Rank;

        public void Set_Name(string name)
        {
            _Name = name;
        }
        public string Get_Name() 
        {
            return _Name;
        }

        public void Set_Car(Car car)
        {
            _PlayerCar = car;
        }
        public String Get_PlayerCar()
        {
            return _PlayerCar.Get_Name();
        }

        public void Set_Money(double money)
        {
            _Money = _Money + money;
        }
        public double Get_Money()
        {
            return _Money;
        }

        public void Set_WinCount(int wins)
        {
            _WinCount = _WinCount + wins;
        }
        public double Get_WinCount()
        {
            return _WinCount;
        }

        public void Set_LossCount(int loss)
        {
            _LossCount = _LossCount + loss;
        }
        public double Get_LossCount()
        {
            return _LossCount;
        }

        public void Set_Rank(int rank)
        {
            _Rank = rank;
        }
        public double Get_Rank()
        {
            return _Rank;
        }

        public void Get_Player()
        {
            Console.WriteLine($"Player name: {Get_Name()},\n" +
                $"Player money: {Get_Money()},\n" +
                $"Player car: ");
                _PlayerCar.Get_Car();
                Console.WriteLine($",\nPlayer win: {Get_WinCount()},\n" +
                $"Player loss: {Get_LossCount()}.");          
        }
        public void Player_Save()
        {
            using (StreamWriter writer = new StreamWriter($"Save.txt", false))
            {
                writer.WriteLine($"{Get_Name()}   {Get_PlayerCar()}  {Get_Money()}  {Get_WinCount()}  {Get_LossCount()}  {Get_Rank()}");
                writer.WriteLine($"{_PlayerCar.Get_Engine()}    {_PlayerCar.Get_Wheels()}    {_PlayerCar.Get_CarCase()}    {_PlayerCar.GetFuel()}    {_PlayerCar.Get_Cost()}");
            }
        }
        public Player(string name)
        {
            _Name = name;
            _PlayerCar = CarList.CommonCar;
            _Money = 500;
            _WinCount = 0;
            _LossCount = 0;
            _Rank = 1;
        }
    }
}
