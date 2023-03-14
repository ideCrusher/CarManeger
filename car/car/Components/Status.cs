using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class Status
    {
        string _Name;
        string _Description;

        public string Get_Name()
        {
            return _Name;
        }
        public string Get_Descr()
        {
            return _Description;
        }

        public Status(string name, string description)
        {
            _Name = name;
            _Description = description;
        }
    }

    public class StatusList
    {
        public static Status Good = new Status("Good", "All good");
        public static Status Fine = new Status("Fine", "Fine");
        public static Status Bad = new Status("Bad", "Go to maintenance");
    }

}
