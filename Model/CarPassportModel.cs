using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CarPassportModel
    {
        public DriverModel Owner { get; set; }
        public readonly CarModel Car;

        public CarPassportModel(CarModel car)
        {
            Car = car;
        }

    }
}
