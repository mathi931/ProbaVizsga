using ProbaVizsga.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaVizsga.Methods
{
    class DataAccess
    {
        public List<Vehicle> ImportVehicles(string fileName)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            foreach (string line in File.ReadAllLines(fileName, Encoding.UTF8))
            {
                if (line.StartsWith("BUS"))
                {
                    vehicles.Add(new Bus(line));
                }
                else if (line.StartsWith("CAR"))
                {
                    vehicles.Add(new Car(line));
                }
            }

            return vehicles;
        }

        public void ExportVehicles(string fileName, List<Vehicle> vehicles)
        {
            try
            {
                StreamWriter export = new StreamWriter(fileName, false, Encoding.UTF8);
                foreach (Vehicle vehicle in vehicles)
                {
                    if(vehicle is Bus)
                    {
                        export.WriteLine((vehicle as Bus).ToCSV());
                    }
                    else if(vehicle is Car)
                    {
                        export.WriteLine((vehicle as Car).ToCSV());
                    }
                }
                export.Close();
            }
            catch (Exception)
            {
                throw new Exception("Error during the export");
            }
        }
    }
}
