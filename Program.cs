namespace Masala
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW","X7",2023,11374,200);
            string result = car.GetCarInfo();
            System.Console.WriteLine(result);
            car.CalculateDepreciation(2024);
        }
    }
}