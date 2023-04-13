using System.Drawing;

namespace lab10
{
    internal class Program
    {
        public delegate void WasherCar(Car car);
        static void Main(string[] args)
        {
            Washer wash = new Washer();
            WasherCar washer;
            washer = wash.Wash;
            Car car = new Car("синий","Киа", "20");
            washer(car);
        }
    }

    public class Car
    {
        public string color;
        public string mark;
        public string number;

        public Car(string color, string mark, string number)
        {
            this.color = color;
            this.mark = mark;
            this.number = number;
        }
    }

    public class Garage
    {
        List<string> car = new List<string>();
    }

    public class Washer
    {
        public void Wash(Car car) => Console.WriteLine("Машина марки " + car.mark + " цветом " + car.color + " номером " + car.number + " сейчас на мойке.");
    }
    
}