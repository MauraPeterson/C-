using System;

public abstract class User2
{
    public bool Verifies { get; set; } = false;
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    virtual public void HelloToConsole()
    {
        Console.WriteLine("Hello, my name is " +  FullName);
    }
}