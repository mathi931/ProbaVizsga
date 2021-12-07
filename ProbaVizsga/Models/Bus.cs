using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaVizsga.Models
{
    class Bus : Vehicle
    {
        public bool DoubleLong { get; set; }

        public Bus(bool doubleLong, string id, int registered, EGas gas) : base(id, registered, gas)
        {
            DoubleLong = doubleLong;
        }

        public Bus(string vehicle) : base(vehicle)
        {
            string[] line = vehicle.Split(';');
            DoubleLong = bool.Parse(line[3].Trim());
        }

        public override string ToCSV()
        {
            return $"BUS;{base.ToCSV()};{DoubleLong}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} {(DoubleLong ? "Long" : "Short")}";
        }
    }
}
