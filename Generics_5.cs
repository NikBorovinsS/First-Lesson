using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generics_5
{
    class Car
    {
        private string _CarName;
        private string _ReleaseYear;

        public Car(string Name, string Year)
        {
            _CarName = Name;
            _ReleaseYear = Year;
        }

        public string GetCarInfo()
        {
            return _CarName + " " + _ReleaseYear;
        }
    }
    class CarCollection<T>
    {
        private ArrayList _Cars;

        public CarCollection()
        {
            _Cars = new ArrayList();
        }

        public void Addcar(T Car)
        {
            _Cars.Add(Car);
        }

        public T this[int index]
        {
            get 
            {
                return (T)_Cars[index];
            }
        }

        public int CountOfCars
        {
            get { return _Cars.Count; }
        }

        public void DeleteAllCars()
        {
            _Cars.Clear();
        }
    }

    class Generics_5
    {
        static void Main(string[] args)
        {
            CarCollection<Car> Parking = new CarCollection<Car>();

            Parking.Addcar(new Car("Pontiac GTO", "1967"));

            Console.WriteLine(Parking[0].GetCarInfo());

            Console.WriteLine(Parking.CountOfCars);

            Parking.DeleteAllCars();
        }
    }
}
