// See https://aka.ms/new-console-template for more information
internal class Sample
{
    public static int value = 42;
    static Sample()
    {
        Console.WriteLine("Sample() 정적 생성자 호출!!");
    }
    public Sample()
    {
        Console.WriteLine("Sample() 일반 생성자 호출!!");
    }
    ~Sample()
    {
        Console.WriteLine("샘플 객체의 소멸자가 호출되었습니ㅏㄷ.");
    }
}