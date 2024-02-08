namespace SkipWhile.SkipTake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
{
                new Car("Suzuki", "JP"),
                new Car("Toyota", "JP"),
                new Car("Opel", "DE"),
                new Car("Kamaz", "RUS"),
                new Car("Lada", "RUS"),
                new Car("Lada", "RUS"),
                new Car("Honda", "JP"),
            };

            Console.WriteLine("Not Japan car:");
            var NotJapanCar = cars.SkipWhile(car => car.CountryCode == "JP");

            foreach (var NotJP in NotJapanCar)
            { Console.WriteLine(NotJP.Manufacturer + " " + NotJP.CountryCode); }

            Console.WriteLine();

            Console.WriteLine("Japan car");
            var JapanCar = cars.TakeWhile(car => car.CountryCode == "JP");

            foreach (var CarJP in JapanCar)
            {
                Console.WriteLine(CarJP.Manufacturer);
            }

            Console.WriteLine();

            var NotAllJPCar = cars.RemoveAll(car => car.CountryCode == "JP");
            
            foreach (var car in cars)
                Console.WriteLine(car.Manufacturer);


        }
    }
    public class Car
    {
        public string Manufacturer { get; set; }
        public string CountryCode { get; set; }

        public  Car(string manufacturer, string countryCode)
        {
            Manufacturer = manufacturer;
            CountryCode = countryCode;
        }
    }

}