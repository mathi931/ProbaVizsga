using ProbaVizsga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaVizsga.Methods
{
    class IDGenerator
    {
        public string SerialNo { get; set; }

        public IDGenerator()
        {
            SerialNo = DateTime.Now.Ticks.ToString().Substring(6, 5);
        }
        public string GenerateID(ESwitch vehicleType)
        {
            switch (vehicleType)
            {
                case ESwitch.Choose:
                    return null;

                case ESwitch.Bus:
                    return $"BUS-{SerialNo}";

                case ESwitch.Auto:
                    return $"CAR-{SerialNo}";
                default:
                    return null;
            }
        }
    }
}
