using System;
using System.Collections.Generic;
using System.Linq;

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

    public User()
    {
        Name = "None";
        LastName = "None";
    }

    public override int GetHashCode()
    {
        return FullName.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        //if(obj != null) return false;
        if(obj.GetType() != typeof(User)) return false;

        User user = (User)obj;

		return Enumerable.SequenceEqual(UserName, user.UserName);

    }

    public void printName(int numOfPrints = 1)
    {
        for(int i = 0; i < numOfPrints; i++)
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public static void PrintUser(User user)
    {
        user.printName();
	}

    public static int Find(List<User> users, string fullName)
    {
        for(int i = 0; i < users.Count; i++)
        {
            if (users[i].FullName == fullName)
            {
                return i;
            }
        }
        return -1;
    }

    public static int Find(List<User> users, User user)
    {
        for(int i =0; i < users.Count;i++)
        {
            if (users[i].Equals(user))
            {
                return i;
            }
        }
        return -1;
    }

    public void Test(int i)
    {
        i++;
    }

}