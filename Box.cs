// See https://aka.ms/new-console-template for more information
internal class Box
{
    public int width
    {
        get { return width; }
        set {
            if (value > 0) width = value;
            else Console.WriteLine("양수입력");
        }
    }
    public int height
    {
        get { return height; }
        set
        {
            if (value > 0) height = value;
            else Console.WriteLine("양수입력");
        }
    }
    public int Area
    {
        get { return this.width * this.height; }
    }

    public Box(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

  /*  public int Area()
    {
        return this.width * this.height;
    }*/
}