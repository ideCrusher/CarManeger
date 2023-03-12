using System;
using System.Collections.Generic;

namespace car
{
    public class Fuel
    {
        string _Name;
        string _Description;

        float _Cost;

        int _Power;
        public string Get_Name()
        {
            return _Name;
        }

        public string Get_Description()
        {
            return _Description;
        }
        public float Get_Cost()
        {
            return _Cost;
        }

        public int Get_Power()
        {
            return _Power;
        }

        public Fuel(string name, string description, float cost, int power)
        {
            _Name = name;
            _Description = description;
            _Cost = cost;
            _Power = power;
        }
    }

    public class FuelList
    {
        public static Fuel GoldFuel = new Fuel("Gold fuel", "Go go gold fuel", 50, 50);
        public static Fuel SilverFuel = new Fuel("Silver fuel", "Si si silver fuel", 40, 35);
        public static Fuel BronzFuel = new Fuel("Bronz fuel", "Bro bro bronz fuel", 30, 20);
    }
}
