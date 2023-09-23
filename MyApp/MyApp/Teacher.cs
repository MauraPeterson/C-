using System;

public class Teacher : User2
{
    public override void HelloToConsole()
    {
        Console.WriteLine("I am a teacher, my name is " + FullName);
    }
}