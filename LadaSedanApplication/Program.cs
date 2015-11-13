using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Drawing;


namespace LadaSedanApplication
{
    class Program
    {
        static void Main(string[] args)
        {   
            var car = new CarModel("Лада",'D');
            Console.WriteLine("Автосалон приобрел автомобиль: {0}, Kатегории: {1}, Цвет: {2}\n", car.Model, car.Category,car.color.Name); 

            car.color = Color.BlueViolet;
            Console.WriteLine("Автомобиль перекрашен в {0} цвет\n", car.color.Name);
            try
            {
            Console.WriteLine(car.CarPassport.Owner.Name);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Невозможно вывести имя владельца Лады. Сообщение: {0}\n",ex.Message);
            }
            

            var driver = new DriverModel(new DateTime(2011,11,11), "Вольдемар" );
            Console.WriteLine("Нанят новый инструктор: {0} \n", driver.Name ); 
            driver.Category.Add('B');
            driver.Category.Add('C');
            Console.WriteLine("Инструктор Вольдемар имеет {0} {1} категории\n", driver.Category[0], driver.Category[1]);
            
            try
            {
                Console.WriteLine("Смена водителя Лады на Вольдемара;\n");
                car.ChangeOwner(driver, "о777о");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Невозможно изменить водителя: {0};\n",ex.Message);
            }
           

            driver.Category.Add('D');
            Console.WriteLine("Вольдемар получил {0} категорию\n", driver.Category[2]);
            car.ChangeOwner(driver, "о777о");
            
            Console.WriteLine("Номер машины Вольдемара: {0}\n", car.CarNumber);
           

            Console.WriteLine("{0} владелец машины Лада\n", car.CarPassport.Owner.Name);
            Console.ReadLine();




        }
    }
}
