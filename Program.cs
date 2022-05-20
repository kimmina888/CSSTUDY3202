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

    List<int> list = new List<int>() { 52, 273, 32, 24 };
    list.Clear();
    /*  list.Add(52);
      list.Add(273);
      list.Add(32);
      list.Add(64);*/
    list.Remove(52);
    foreach(var item in list)
    {
        Console.WriteLine("Count : " + list.Count + "/ titem " + item);
    }

    Console.WriteLine(Math.Abs(-52273));
    Console.WriteLine(Math.Ceiling(52.237));
    Console.WriteLine(Math.Floor(52.273));
    Console.WriteLine(Math.Max(52, 273));
    Console.WriteLine(Math.Min(52, 273));
    Console.WriteLine(Math.Round(52.273));
    Console.WriteLine(Math.PI);

}