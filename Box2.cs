// See https://aka.ms/new-console-template for more information
internal class Box2
{
    private int width;
    private int height;

    public void serWidth(int width)
    {
        if(width < 0)
        {
            Console.WriteLine("양수 입력 부탁합니다");
        }
        else
        {
            this.width = width;
        }
    }
    public int getWidth()
    {
       return width;
    }

    public void serHeight(int Height)
    {
        if (Height < 0)
        {
            Console.WriteLine("양수 입력 부탁합니다");
        }
        else
        {
            this.height=Height;
        }
    }
    public int getHeight()
    {
        return height;
    }
    public Box2(int width, int height)
    {
        this.width=width;
        this.height=height;
    }
    public Box2()
    {
    }
    
    public int Area()
    {
           return this.width*this.height;
    }
}