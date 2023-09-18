main(args);

static void main(string[] args)
{
    Bumble myBee = new Bumble();
    myBee.echo();
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
}