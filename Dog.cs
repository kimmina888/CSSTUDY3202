// See https://aka.ms/new-console-template for more information
using CSSTUDY3202;

public class Dog : Animal
{
    public String Color{ get; set; }

    public void Bark()
    {
        Console.WriteLine("왈왈 짖습니다.");
    }
}