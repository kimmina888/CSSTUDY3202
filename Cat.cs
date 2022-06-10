// See https://aka.ms/new-console-template for more information
public class Cat
{
    public int Age { get; set; }
    public Cat()
    {
        this.Age = 0;
    }
    internal void Eat()
    {
        Console.WriteLine("냠냠 먹겠습니다.");
    }

    internal void Sleep()
    {
        Console.WriteLine("쿨쿨 잠을 잡니다.");
    }

    internal void Bark()
    {
        Console.WriteLine("냐옹 냐옹 웁니다.");
    }
}