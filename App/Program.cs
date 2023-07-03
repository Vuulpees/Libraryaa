using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraryaa;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта водителя
            Driver driver = new Driver("Иван Иванов", new DateTime(1990, 1, 1), "ул. Главная, 123");

            // Создание объектов автомобилей
            Car car1 = new Car("Toyota Camry", 2018, "Серебристый", "Седан");
            Car car2 = new Car("Ford Focus", 2019, "Черный", "Хэтчбек");

            // Добавление автомобилей к водителю
            driver.Cars.Add(car1);
            driver.Cars.Add(car2);

            // Вывод информации о водителе
            Console.WriteLine("Информация о водителе:");
            Console.WriteLine(driver.ToString());

            // Вывод информации об автомобилях
            Console.WriteLine("\nИнформация об автомобилях:");
            foreach (var car in driver.Cars)
            {
                Console.WriteLine(car.ToString());
            }
            Console.ReadKey();
        }
    }
}
