// See https://aka.ms/new-console-template for more information
using CSSTUDY3202;

static void Main(string[] args) 
{
    Car car = new Car();
    car.SetInTime();
    car.SetOutTime();
    
    Random rand = new Random();
    Console.WriteLine(rand.Next(10, 100));
    Console.WriteLine(rand.Next(10, 100));
    Console.WriteLine(rand.Next(10, 100));
    Console.WriteLine(rand.Next(10, 100));
    Console.WriteLine(rand.Next(10, 100));

    Console.WriteLine(rand.NextDouble());
    Console.WriteLine(rand.NextDouble() * 10);
}