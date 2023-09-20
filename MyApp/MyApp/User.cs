using System;

public class User
{
	public string Name;// public field

    string _firstName = "ariel";// private field
    string _userName = "user";

    public string FirstName { // read only property
        get
        {
            return _firstName.ToUpper();
        }
    }// public property:
    public string LastName { get; set; } // get and set create private feild with auto get/set methods
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }
    
    public string UserName
    {
        get
        {
            return _userName.ToLower();
        }

        set 
        { 
            _userName = value.Trim();
        }
    }


    public void printName()
    {
        Console.WriteLine(FullName);
    }

    public void printName(int numOfPrints)
    {
        for(int i = 0; i < numOfPrints; i++)
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

}