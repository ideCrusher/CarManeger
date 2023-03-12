using System;
using System.Collections.Generic;

namespace car
{
    public class Engine
    {
        string _Name;
        Status _Status = StatusList.Good;

        string _Description;

        int _MaxSpeed;

        double _Expenditure;

        double _Weight;

        double _Cost;

        int _Power;
        public string Get_Name()
        {
            return _Name;
        }
        public void Set_Status(Status status)
        {
            _Status = status;
        }
        public Status Get_Status() 
        {
            return _Status;
        }
        public string Get_Description()
        {
            return _Description;
        }
        public int Get_MaxSpeed()
        {
            return _MaxSpeed;
        }
        public double Get_Expenditure()
        {
            return _Expenditure;
        }
        public double Get_Weight()
        {
            return _Weight;
        }
        public double Get_Cost()
        {
            return _Cost;
        }

        public int Get_Power()
        {
            return _Power;
        }

        public Engine(string name, string description, int maxSpeed, double expenditure, double weight, double cost, int power)
        {
            _Name = name;
            _Description = description;
            _MaxSpeed = maxSpeed;
            _Expenditure = expenditure;
            _Weight = weight;
            _Cost = cost;
            _Power = power;
        }
    }

    public class EngineList
    {
        public static Engine RaceEngine = new Engine("Racing engine", "Racing engine, super fast, but uses more fuel.", 501, 3, 50, 1000, 50);
        public static Engine SmallliterEngine = new Engine("Smallliter engine", "Smallliter engine,uses small fuel.", 240, 1.4, 40, 700, 35);
        public static Engine CommonEngine = new Engine("Common engine", "Common engine.", 260, 2, 70, 500, 20);
    }
}
