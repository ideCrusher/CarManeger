using System;
using System.Collections.Generic;

namespace car
{
    public class Car
    {
        string _Name;

        Engine _Engine;
        List<Wheel> _Wheels;
        Carcase _Carcase;

        Fuel _Fuel;

        double _Cost;

        public string Get_Name()
        {
            return _Name;
        }
        public string Get_Engine()
        {
            return _Engine.Get_Name();
        }
        public string Get_Wheels()
        {
            return _Wheels[0].Get_Name();
        }
        public string GetFuel()
        {
            return _Fuel.Get_Name();
        }
        public double Get_Weight()
        {
            double Weight = 0; 
            Weight = Weight + _Engine.Get_Weight() + _Carcase.Get_Weight();

            foreach(Wheel wheel in _Wheels)
            {
                Weight = Weight + wheel.Get_Weight();
            }

            return Weight;
        }
        public double Get_Cost()
        {
            return _Cost;
        }

        public string Get_CarCase()
        {
            return _Carcase.Get_Name();
        }
        public int Get_Power()
        {
            int Power = 0;
            
            Power = Power + _Engine.Get_Power() + _Carcase.Get_Power() + _Fuel.Get_Power();
            foreach (Wheel wheel in _Wheels)
            {
                Power = Power + wheel.Get_Power();
            }

            return Power;
        }
        public void Get_Car()
        {
            Console.WriteLine($"Название машины:{_Name},\n" +
                $"Двигатель: {_Engine.Get_Name()},\n" +
                $"Колеса: {Get_Wheels()},\n" +
                $"Корпус: {_Carcase.Get_Name()},\n" +
                $"Топливо: {_Fuel.Get_Name()},\n" +
                $"Мощность: {Get_Power()},\n" +
                $"Вес: {Get_Weight()},\n" +
                $"Цена: {_Cost}.\n");
        }
        public Car(string name, Engine engine, List<Wheel> wheels, Carcase carcase, Fuel fuel, double cost)
        {
            _Name = name;
            _Engine = engine;
            _Wheels = wheels;
            _Carcase = carcase;
            _Fuel = fuel;
            _Cost = cost;
        }
        
    }

    public class CarList
    {
        public static Car CommonCar = new Car("Common car",EngineList.CommonEngine, WheelList.Get_CommonWheels(), CarcaseList.CommonCarcase, FuelList.BronzFuel, 1500);
        public static Car UncomonCar = new Car("Uncomon car", EngineList.SmallliterEngine, WheelList.Get_CommonWheels(), CarcaseList.CommonCarcase, FuelList.SilverFuel, 2500);
        public static Car RareCar = new Car("Rare car", EngineList.SmallliterEngine, WheelList.Get_SportWheels(), CarcaseList.LightweightCarcase, FuelList.SilverFuel, 3500);
        public static Car EpicCar = new Car("Epic car", EngineList.RaceEngine, WheelList.Get_CommonWheels(), CarcaseList.HeavyCarcase, FuelList.GoldFuel, 5000);
        public static Car LegendaryCar = new Car("Legendary car", EngineList.RaceEngine, WheelList.Get_SportWheels(), CarcaseList.LightweightCarcase, FuelList.GoldFuel, 7500);

        public static List<Car> CarListList = new List<Car>();
        
        public static List<Car> AddCarListList()
        {
            CarListList.Clear();

            CarListList.Add(CommonCar);
            CarListList.Add(UncomonCar);
            CarListList.Add(RareCar);
            CarListList.Add(EpicCar);
            CarListList.Add(LegendaryCar);

            return CarListList;
        }
    }

}
