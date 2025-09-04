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
        }
    }
}
