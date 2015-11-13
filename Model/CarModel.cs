using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Drawing;


namespace Model
{
   public class CarModel
   {
       public readonly string Model;
       public Color color { get; set; }
       public string CarNumber { get; private set; }
       public readonly char Category;
       public readonly CarPassportModel CarPassport;
       public CarModel(string model,char category)
       {
           this.Model = model;
           this.color = Color.Blue;
           this.Category = category;
           this.CarPassport = new CarPassportModel(this); 
            
       }
        
       public void ChangeOwner(DriverModel driver, string carNumberNew )
       {
           this.CarPassport.Owner = driver;
           this.CarNumber = carNumberNew;
           driver.OwnCar(this);
       }



   }
}
