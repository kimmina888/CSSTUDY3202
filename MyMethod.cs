// See https://aka.ms/new-console-template for more information
internal class MyMethod
{
    public static bool ABS(int v)
    {
       if(v < 0)
        {
            int r = v *= -1;
            return r;
        }
        return v;
    }

    public static bool ABS(double v)
    {
        if (v < 0)
        {
            return -v;
        }
        return v;
    }

    public static bool ABS(long v)
    {
        if (v < 0)
        {
            return -v;
        }
        return v;
    }
}