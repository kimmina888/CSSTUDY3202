// See https://aka.ms/new-console-template for more information
internal class Product
{
    public static int counter = 0;
    public int id;
    public static string MADEIN = "Korea";
    /// <summary>
    /// 이름
    /// </summary>
    public string name = "무명";
    /// <summary>
    /// 가격
    /// </summary>
    public int price = 1000;
    public Product()
    {

    }

    public Product(string name, int price)
    {
        Product.counter++;
        this.id = counter;
        this.name = name;
        this.price = price;
        Console.WriteLine(this.ToString());
    }

    public override string ToString()
    {
        return this.id + " : " + this.name + " ( " + this.price + " 원 )";
    }
}   