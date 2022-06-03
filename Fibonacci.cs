// See https://aka.ms/new-console-template for more information
internal class Fibonacci
{
    private static Dictionary<int, long> memo = new Dictionary<int, long>();

    public Fibonacci()
    {
    }

    internal int Get(int v)
    {
        Console.WriteLine("Get(" + v + ") 호출 ->");
        if (v < 0) { return 0; }
        if(v == 1) { return 1; }

        Console.WriteLine();
        if (memo.ContainsKey(v)) { return (int)memo[v]; }
        else
        {
            return (int)(memo[v] = Get(v - 2) + Get(v - 1));
        }
    }
}