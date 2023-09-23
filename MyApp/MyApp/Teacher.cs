using System;

public class Teacher : User2
{
    public Teacher(string firstName, string lastName) : base(firstName, lastName)
    {
    }
    public override void HelloToConsole()
    {
        Console.WriteLine("I am a teacher, my name is " + FullName);
    }
}