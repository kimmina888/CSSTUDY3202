// See https://aka.ms/new-console-template for more information
internal class MyMethod
{
    public static int ABS(int v)
    {
       if(v < 0)
        {
            int r = v *= -1;
            return r;
        }
        return v;
    }

    public static double ABS(double v)
    {
        if (v < 0)
        {
            return -v;
        }
        return v;
    }

    public static long ABS(long v)
    {
        if (v < 0)
        {
            return -v;
        }
        return v;
    }
}