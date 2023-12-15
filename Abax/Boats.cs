using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax
{
    internal class Boats : IVehicle
    {
        public int Effect { get; set; }
        public string Idnr { get; set; }
        private int _speed;
        private int _tonnage;

        public Boats(int speed, int tonnage, int BoatEffect, string IDnr)
        {
            _speed = speed;
            _tonnage = tonnage;
            Effect = BoatEffect;
            Idnr = IDnr;
        }
        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Båten {Idnr} har {Effect}kw");
            Console.WriteLine($"Den har en toppfart på {_speed}knop og veier {_tonnage}kg bruttotonnasje");
        }
    }
}
