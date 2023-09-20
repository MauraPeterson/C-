using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

main(args);

static void main(string[] args)
{
    userStuff();
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

