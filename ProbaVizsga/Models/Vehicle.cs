using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaVizsga.Models
{
    enum ESwitch
    {
        Choose, Bus, Auto
    }

    enum EGas
    {
        benzin,gasoil,hybrid
    }
    abstract class Vehicle
    {
        protected Vehicle(string iD, int registered, EGas gas)
        {
            ID = iD;
            Registered = registered;
            Gas = gas;
        }

        protected Vehicle(string vehicle)
        {
            string[] line = vehicle.Split(';');
            ID = line[1].Trim();
            Registered = int.Parse(line[2].Trim());
            Gas = (EGas)int.Parse(line[3].Trim());
        }

        public string ID { get; set; }
        public int Registered { get; set; }
        public EGas Gas { get; set; }

        //BUSZ;BUSZ001;2021;0;True
        public virtual string ToCSV()
        {
            return $"{ID};{Registered};{(int)Gas}";
        }

        public override string ToString()
        {
            return $"{ID} {Registered} {Gas}";
        }
    }
}
