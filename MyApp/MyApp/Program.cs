main(args);

static void main(string[] args)
{
    Bumble myBee = new Bumble();
    myBee.referenceTypes();
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
}