using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DriverModel
    {
        public readonly DateTime LicenceDay;
        public readonly string Name;

        public DriverModel(DateTime licenceDay, string name)
        {
            LicenceDay = licenceDay;
            Name = name;
            Category = new List<char>();
        }

        public int Experience
        {
            get
            {
                return (DateTime.Now - LicenceDay).Days / 365;
            }
        }

        public List<char> Category { get; set; }
      
         
        public CarModel Car { get; private set; }


        public void OwnCar(CarModel car)
        {
            if (Category.Any(category => category == car.Category) )
            {
                this.Car = car;
            }
            else
            {
                throw new NullReferenceException("У водителя нет прав данной категории");
            }

            


        }









    }
}
