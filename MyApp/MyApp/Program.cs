using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

main(args);

static void main(string[] args)
{
    inheritanceStuff();
}

static void inheritanceStuff()
{
    Student me = new Student();
    me.FirstName = "Test";
    me.LastName = "Test";

    Teacher you = new Teacher();
    you.FirstName = "Teach";
    you.LastName = "Class";

    List<User2> users = new List<User2>() { me, you};
    
    foreach(User2 usr in users)
    {
        usr.HelloToConsole();
    }

    
}

static void userStuff()
{
    User myUser = new User();
    myUser.LastName = "Mermaid";

    Console.WriteLine(myUser.UserName);
    myUser.UserName = "   MyLittleMermaid";
    Console.WriteLine(myUser.UserName);

    User user2 = new User();
    user2.LastName = "Human";
    user2.UserName = "                IGotLEGS";

    List<User> users = new List<User>();
    users.Add(myUser);
    users.Add(user2);


    Console.WriteLine(user2.Equals(myUser));
    myUser.UserName = user2.UserName;
    Console.WriteLine(user2.Equals(myUser));
    //Console.WriteLine(user2.Equals(null));

    int x = 50;
    user2.Test(x);
    Console.WriteLine(x);
}



//static void printUser(User user) // changes the user
//{
//    User.PrintUser(user);
//}

//static void personStuff()
//{
//    Person person = new Person();
//    person.FirstName = "Cool";
//    person.LastName = "Guy";
//}

//static void bumbleStuff()
//{
//    Bumble myBee = new Bumble();

//    myBee.nestedLists();

//}

