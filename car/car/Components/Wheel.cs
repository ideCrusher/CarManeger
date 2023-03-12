using System;
using System.Collections.Generic;

namespace car
{
    public class Wheel
    {
        string _Name;
        string _Description;

        Status _Status = StatusList.Good;

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

        public Wheel(string name, string description, double weight, double cost, int power)
        {
            _Name = name;
            _Description = description;
            _Weight = weight;
            _Cost = cost;
            _Power = power;
        }
    }

    public class WheelList
    {
        static Wheel SportWheel = new Wheel("Sport wheel", "Good sport wheel, for high speed.", 5, 35, 50);
        static Wheel WinterWheel = new Wheel("Winter wheel", "Its the wheel have a studded tires.", 7, 28, 35);
        static Wheel CommonWheel = new Wheel("Normal wheel", "Its a good wheel.", 8, 20, 20);

        static List<Wheel> SportWheelList = new List<Wheel>();
        static List<Wheel> WinterWheelList = new List<Wheel>();
        static List<Wheel> CommonWheelList = new List<Wheel>();

        public static List<Wheel> Get_SportWheels()
        {
            int i = 0;
            while (i < 4)
            {
                SportWheelList.Add(SportWheel);
                i++;
            }
            return SportWheelList;
        }
        public static List<Wheel> Get_WinterWheels()
        {
            int i = 0;
            while (i < 4)
            {
                WinterWheelList.Add(WinterWheel);
                i++;
            }
            return WinterWheelList;
        }
        public static List<Wheel> Get_CommonWheels()
        {
            int i = 0;
            while (i < 4)
            {
                CommonWheelList.Add(CommonWheel);
                i++;
            }
            return CommonWheelList;
        }
    }
}
