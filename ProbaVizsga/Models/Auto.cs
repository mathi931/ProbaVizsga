using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaVizsga.Models
{
    class Car : Vehicle
    {
        public bool SportLine { get; set; }

        public Car(bool sportLine, string id, int registered, EGas gas): base( id, registered, gas)
        {
            SportLine = sportLine;
        }

        public Car(string vehicle): base(vehicle)
        {
            string[] line = vehicle.Split(';');
            SportLine = bool.Parse(line[3].Trim());
        }

        //BUSZ;BUSZ001;2021;0;True
        public override string ToCSV()
        {
            return $"AUTO;{base.ToCSV()};{SportLine}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} {(SportLine ? "Sport Line" : "Basic")}";
        }

    }
}
