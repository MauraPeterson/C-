using System;

public class Student : User2, ITalk
{
    public int test { get; set; }
    public Student(string firstName, string lastName) : base(firstName, lastName)
    {

    }

    public override void HelloToConsole()
    {
        Console.WriteLine("Hi, I'm a student, my name is " + FullName);
    }

    
}