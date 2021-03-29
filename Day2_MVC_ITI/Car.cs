using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2_MVC_ITI
{
    public class Car
    {
        public int Num { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }

        public Car() { }
        public Car(int num, string col, string mod, string man) 
        {
            Num = num; Color = col; Model = mod; Manufacturer = man;
        }


    }
}