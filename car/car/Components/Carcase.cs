using System;
using System.Collections.Generic;

namespace car
{
    public class Carcase
    {
        string _Name;
        string _Description;

        Status _Status = StatusList.Good;

        float _Weight;

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
        public float Get_Weight()
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

        public Carcase(string name, string description, float weight, double cost, int power)
        {
            _Name = name;
            _Description = description;
            _Weight = weight;
            _Cost = cost;
            _Power = power;
        }
    }

    public class CarcaseList
    {
        public static Carcase LightweightCarcase = new Carcase("Light weight carcase", "Light weight carcase.", 200, 500, 50);
        public static Carcase HeavyCarcase = new Carcase("Heavy carcase", "Heavy carcase.", 400, 350, 35);
        public static Carcase CommonCarcase = new Carcase("Common carcase", "Common carcase.", 300, 200, 20);
    }

}
