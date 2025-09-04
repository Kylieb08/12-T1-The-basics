namespace _12_T1_The_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kylie

            string aFriend = "Maira";
            string firstFriend = "Maria";
            string secondFriend = "Sage";

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");
        }
    }
}
