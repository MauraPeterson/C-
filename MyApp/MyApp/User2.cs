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
    public string FirstName { get; }
    public string LastName { get; }

    public User2(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    virtual public void HelloToConsole()
    {
        Console.WriteLine("Hello, my name is " +  FullName);
    }
}