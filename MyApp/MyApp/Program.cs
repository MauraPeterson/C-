using System.Security.Cryptography.X509Certificates;

main(args);

static void main(string[] args)
{
    Bumble myBee = new Bumble();
    myBee.clickClack();
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

    public void infinity()
    {
        double x = Math.Pow(9999,99999999999);
        Console.WriteLine(double.IsInfinity(x));
    }

    public void round()
    {
        double a = 50.5;
        double b = 51.5;
        Console.WriteLine($"A={Math.Round(a)} B={Math.Round(b)}");
        Console.WriteLine($"A={Math.Round(a, 0, MidpointRounding.AwayFromZero)} B={Math.Round(b, 0, MidpointRounding.AwayFromZero)}");
    }

    public void Char()
    {
        char a = 'a';
        int unicodeMax = 65536;
        int asciiMax = 255;
        for( int i = 0; i < asciiMax; i++)
        {
            a = (char)(i);
            Console.WriteLine($"{i} = {a}|");
        }
        
    }

    public void Hearts()
    {

        char[] characters = new char[181];

        for(int i = 0;i < 180; i = i + 2)
        {
            characters[i] = (char)3;
            characters[i+1] = (char)32;
        }
        characters[180]= (char)10;
        string hearts = new string(characters);
        Console.Write(hearts);
    }

    public void backslash()
    {
        string a = "\'";
        string b = "\"";
        string c = "\\";
        string d = "\0";
        string e = "\a";
        string f = "\b";
        string g = "\f";
        string h = "\n";
        string i = "\r";
        string j = "\t";
        string k = "\v";

        Console.Write (a);
        Console.Write (b);
        Console.Write (c);
        Console.Write(d);
        Console.Write (e);
        Console.Write (f);
        Console.Write (g);
        Console.Write (h);
        Console.Write (i);
        Console.Write (j);
        Console.Write (k);

    }

    public void clickClack()
    {
        Console.Write("\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a");
    }

}