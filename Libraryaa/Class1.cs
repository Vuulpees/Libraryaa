using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryaa
{
    
    
     public class Driver : IComparable<Driver>
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public List<Car> Cars { get; set; }

        public Driver(string fullName, DateTime dateOfBirth, string address)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Address = address;
            Cars = new List<Car>();
        }

        public int CompareTo(Driver other)
        {
            return FullName.CompareTo(other.FullName);
        }

        public override string ToString()
        {
            return $"Driver: {FullName}, Date of Birth: {DateOfBirth.ToShortDateString()}, Address: {Address}";
        }
    }
    public class Car : IComparable<Car>
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string BodyType { get; set; }

        public Car(string brand, int year, string color, string bodyType)
        {
            Brand = brand;
            Year = year;
            Color = color;
            BodyType = bodyType;
        }

        public int CompareTo(Car other)
        {
            return Brand.CompareTo(other.Brand);
        }

        public override string ToString()
        {
            return $"Car: {Brand}, Year: {Year}, Color: {Color}, Body Type: {BodyType}";
        }
    }
}
