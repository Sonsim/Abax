using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax
{
    internal class Plane : IVehicle
    {
        public int Effect { get; set; }
        public string Idnr { get; set; }

        private int _wingspan;
        private int _loadcapacity;
        private int _weigth;
        private string _type;

        public Plane(int PlaneEffect, string IDnr, int Wingspan, int Loadcapacity, int Weigth, string Type)
        {
            Effect = PlaneEffect;
            Idnr = IDnr;
            _wingspan = Wingspan;
            _loadcapacity = Loadcapacity;
            _weigth = Weigth;
            _type = Type;
        }
        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Flyet har kjennetegn {Idnr}");
            Console.WriteLine($"Det har {Effect}kw effekt");
            Console.WriteLine($"Flyet har et vingespenn på {_wingspan}m og en lastevne på {_loadcapacity} tonn");
            Console.WriteLine($"Det veier {_weigth} og er et {_type}");
        }

        public void Fly()
        {
            Console.WriteLine($"{Idnr} har lettet og flyr mot New York");
        }
    }

}
