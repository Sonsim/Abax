using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax
{
    internal class Cars : IVehicle
    {
        public int Effect { get; set; }
        public string Idnr { get; set; }

        private int _maxspeed;
        private string _color;
        private string _type;

        public Cars(int CarEffect, string Regnr, int Maxspeed, string Color, string Type)
        {
            Effect = CarEffect;
            Idnr = Regnr;
            _maxspeed = Maxspeed;
            _color = Color;
            _type = Type;
        }

        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Bilen har {Effect}KW effekt");
            Console.WriteLine($"Registreringsnummeret er {Idnr}");
            Console.WriteLine($"Den har {_maxspeed} km/t som maksfart");
            Console.WriteLine($"Bilen er {_color} og er et {_type}");
        }

        public void Drive()
        {
            Console.WriteLine($"{Idnr} kjører mot Trondheim");
        }

        public string GetType()
        {
            return _type;
        }

        public string GetColor()
        {
            return _color;
        }

        public int GetMaxSpeed()
        {
            return _maxspeed;
        }
    }
}
