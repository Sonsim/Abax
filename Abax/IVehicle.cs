using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax
{
    internal interface IVehicle
    {
        int Effect { get; set; }
        string Idnr { get; set; }

        void PrintInfo();
    }
}
