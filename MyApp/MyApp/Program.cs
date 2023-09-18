main(args);

static void main(string[] args)
{
    Bumble myBee = new Bumble();
    myBee.maxValues();
}

class Bumble
{
    public void echo()
    {
        string? x = Console.ReadLine();
        Console.WriteLine($"{x} bzzzz!");
    }
    public void print(string arg)
    {
        Console.WriteLine("bzzzzzzzzz!");
        Console.WriteLine(arg);
    }

    public void literalTypes()
    {
        int a = -5;
        uint b = 5;
        char c = 'a';
        float d = 5.5f;
        double e = 5.5;
        decimal f = 5.5M; // this one is precise use with money
        bool g = true;
        string h = "Hello"; // strings are reference types but can be used like literals
        System.Int32 i = 7; // .NET type for things that use multiple languages with .NET
    }

    public void referenceTypes()
    {
        int[] a = { -5 };
        int[] b = a;
        b[0] = 3;

        Console.WriteLine($"A={a[0]}, B={b[0]}");
    }

    public void valueTypes()
    {
        int a = -5;
        int b = a;
        a = 3;
        Console.WriteLine($"A={a}, B={b}");
    }

    public void maxValues()
    {
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(uint.MaxValue);
        Console.WriteLine(double.MaxValue);
        Console.WriteLine(decimal.MaxValue);
        Console.WriteLine(float.MaxValue);
        Console.WriteLine(long.MaxValue);
        Console.WriteLine(short.MaxValue);
        Console.WriteLine(ushort.MaxValue);
        Console.WriteLine(ulong.MaxValue);
    }
}