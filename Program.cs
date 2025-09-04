namespace _12_T1_The_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kylie

            //Friend variables
            string aFriend = "Maira";
            string firstFriend = "Maria";
            string secondFriend = "Sage";

            //Greeting variables
            string greeting = "     Hello, World!       ";
            string trimmedGreeting = greeting.TrimStart();
            trimmedGreeting = greeting.Trim();

            //Replace variables
            string sayHello = "Hello, World!";

            //Search String variables
            string songLyrics = "You say goodbye, and I say hello";

            //Friends
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");

            //Greetings
            Console.WriteLine($"[{greeting}]");
            Console.WriteLine($"[{trimmedGreeting}]");

            //Replace
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            //Search String
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine(songLyrics.StartsWith("You"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
        }
    }
}



//Assignment

/* 1. Provide two different ways to write a greeting to someone who's name is stored in a string variable firstName.
 * Use string interpolation and the + operator. Which method do you prefer? 

* There are two ways to write something stored in a string variable. The first is to use the + operator.
 * It connects two strings together. The second is to use string interpolation. It is done by placing a $ 
 * before the string, and then placing the variable in curly braces {}. I prefer string interpolation because it's more neat. */

/* 2. How would you print out the number of characters in a string called passPhrase?
 * Console.WriteLine(passPhrase.Length); */

/* 3. What does the Trim() method do? Why might this be useful?
 * The Trim() method removes spaces before and after a string. This is useful because sometimes the spaces go unnoticed
 * and it is easier to remove them than to find them. */