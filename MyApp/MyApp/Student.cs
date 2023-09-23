using System;

public class Student : User2
{
    public override void HelloToConsole()
    {
        Console.WriteLine("Hi, I'm a student, my name is " + FullName);
    }
}