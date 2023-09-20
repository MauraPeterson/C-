using System.Collections.Generic;
using System.Linq;
using System;

class Bumble
{
    public void printUser(User user)
    {
        user.UserName = "buzz";
        Console.WriteLine("user: " + user.UserName);
        user.printName();
    }

    public void arrayToList()
    {
        string[] array = { "bee", "wasp", "fly" };
        List<string> list = array.ToList();
    }

    public void listToArray()
    {
        List<string> strings = new List<string>();
        string[] stringArray = strings.ToArray();
    }

    public void nestedLists()
    {
        List<List<int>> numbersLists = new List<List<int>>()
        {
            new List<int>{ 3, 4, 5 },
            new List<int>{ 45, 78, 3, 5, 6 },
            new List<int>{ 3, 4 }
        };

        foreach (List<int> numberList in numbersLists)
        {
            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }

    public void forEach()
    {
        List<string> bees = new List<string>();
        bees.Add("buzz");
        bees.Add("barnibee");
        bees.Add("Casper");

        foreach (string bee in bees)// for each works with arrays too
        {
            bee.ToUpper(); // doesnt change anything, cant do bee = bee.ToUpper() 
        }

        printList(bees);

        foreach (string bee in bees) // for each is good for reading items, not changing
        {
            Console.Write(bee + " ");
        }

    }

    public void printList(List<string> list)
    {
        foreach (string item in list)
        {
            Console.Write(item + " ");
        }
        Console.Write('\n');
    }

    public void lists()
    {
        List<string> list = new List<string>();
        list.Add("buzz");
        list.Add("barnibee");
        list.Add("Casper");

        var list1 = new List<string>() { "beeble", "bubbles", "bumbalina" };

        Console.WriteLine(list[1]);
        Console.WriteLine(list1[2]);

        list.Insert(1, "beeble");

        Console.WriteLine(list[1]);
        Console.WriteLine(list[2]);

        list.Remove("buzz");

        Console.WriteLine(list[0]);
        Console.WriteLine(list[1]);

        if (list.Contains("beeble"))
        {
            Console.WriteLine("yup");
        }

        Console.WriteLine(list.IndexOf("buzz"));

        List<string> list2 = new List<string> { "beeble", "barnibee", "Casper" };

        if (list.SequenceEqual(list1))
        {
            Console.WriteLine("matching 1");
        }

        if (list.SequenceEqual(list2))
        {
            Console.WriteLine("matching 2");
        }

        printList(list);

        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].ToUpper();
        }

        printList(list);
    }

    public void jaggedArray()
    {
        int[][] beeColonies =
        {
            new int[] { 1, 2, 3},
            new int[] { 5, 3 },
            new int[] { 5, 3, 5, 4 }
        };

        for (int i = 0; i < beeColonies.Length; i++)
        {
            printArray(beeColonies[i]);
            Console.Write("\n");
        }
    }

    public void twoDArray()
    {
        int[,] beeCouples = { { 3, 4 }, { 5, 8 }, { 9, 6 } };

        for (int i = 0; i < beeCouples.GetLength(0); i++)
        {
            for (int j = 0; j < beeCouples.GetLength(1); j++)
            {
                Console.Write(beeCouples[i, j] + " ");
            }
            Console.Write("\n");
        }
    }

    public void compareArray()
    {
        int[] bees1 = { 30, 430, 34, 39 };
        int[] bees2 = { 30, 430, 34, 39 };

        if (Enumerable.SequenceEqual(bees1, bees2))
        {
            Console.WriteLine("matching");
        }
    }

    public void reverseArray(string[] array)
    {
        Array.Reverse(array);
    }

    public void sortArray()
    {
        string[] bees = { "buzz", "casper", "barnibee" };

        Array.Sort(bees);

        reverseArray(bees);

        printArray(bees);
    }

    public void searchArray()
    {
        string[] bees = { "buzz", "casper", "barnibee" };

        Console.WriteLine(Array.IndexOf(bees, "casper"));
    }

    public void printArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    public void printArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i].ToString() + " ");
        }
    }

    public void fillArray()
    {
        int[] beeNums = new int[3];

        for (int i = 0; i < beeNums.Length; i++)
        {
            beeNums[i] = Convert.ToInt32(Console.ReadLine());
        }

        printArray(beeNums);
    }

    public void myArray()
    {
        int[] bees = new int[10];
        bees[0] = 1;

        int[] hives = { 900, 800, 300 };

        Console.WriteLine(bees[0]);
        Console.WriteLine(hives[2]);

    }

    public void Continue()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 8)
            {
                continue;
            }
            Console.WriteLine(i.ToString());
        }
    }

    public void Break()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 2)
            {
                break;
            }
            Console.WriteLine("bzzzz");
        }
    }


    public void Triforce()
    {
        for (int i = 0; i < 10; i++)
        {
            string heart = ((char)3) + " ";
            triangleDown(i, heart);
            triangleUp(i, heart);
            triangleDown(i, heart);
            triangleUp(i, " ");
            triangleUp(i, " ");
            triangleUp(i, " ");
            triangleUp(i, " ");
            triangleDown(i, heart);
            triangleUp(i, heart);
            triangleDown(i, heart);
            Console.WriteLine();
        }

        for (int i = 0; i < 10; i++)
        {
            string heart = ((char)3) + " ";
            triangleDown(i, heart);
            triangleUp(i, " ");
            triangleUp(i, " ");
            triangleUp(i, " ");
            triangleUp(i, " ");
            triangleDown(i, heart);
            triangleDown(i, heart);
            triangleUp(i, " ");
            triangleUp(i, " ");
            triangleUp(i, " ");
            triangleUp(i, " ");
            triangleDown(i, heart);
            Console.WriteLine();
        }
    }

    private void triangleDown(int i, string str)
    {
        for (int j = i; j < 10; j++)
        {
            Console.Write(str);
        }
    }

    private void triangleUp(int i, string str)
    {
        for (int j = i; j > 0; j--)
        {
            Console.Write(str);
        }
    }

    public void doWhile()
    {
        int happiness = 10;

        do
        {
            Console.WriteLine("bzzzzz");
            happiness++;
        }
        while (happiness < 3);
    }

    public void WhileLoop()
    {
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine("bzz ");
            i++;
        }
    }

    public void Ternary(int num)
    {
        string answer = num == 5 ? "heck yes" : "heck no";
        Console.WriteLine(answer);
    }

    public void Switch(string name)
    {
        switch (name)
        {
            case "Cool Guy":
                Console.WriteLine("Woah your such a Cool Guy");
                break;
            case "Bad Guy":
                Console.WriteLine("Duh");
                break;
            default:
                Console.WriteLine($"Hello {name} bzzz");
                break;
        }
    }

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

        Console.WriteLine($"{a} {b} {c} {d} {e} {f} {g} {h} {i}");
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
        double x = Math.Pow(9999, 99999999999);
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
        for (int i = 0; i < asciiMax; i++)
        {
            a = (char)(i);
            Console.WriteLine($"{i} = {a}|");
        }

        for (int i = 0; i < unicodeMax; i++)
        {
            a = (char)(i);
            Console.WriteLine($"{i} = {a}|");
        }

    }

    public void Hearts()
    {

        char[] characters = new char[181];

        for (int i = 0; i < 180; i = i + 2)
        {
            characters[i] = (char)3;
            characters[i + 1] = (char)32;
        }
        characters[180] = (char)10;
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
        string k = @"\v";

        Console.Write(a);
        Console.Write(b);
        Console.Write(c);
        Console.Write(d);
        Console.Write(e);
        Console.Write(f);
        Console.Write(g);
        Console.Write(h);
        Console.Write(i);
        Console.Write(j);
        Console.Write(k);

    }

    public void clickClack()
    {
        Console.Write("\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a\a");
    }

}