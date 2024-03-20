namespace ex10while_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            while (input != 4)
            {
            Console.WriteLine("**************");
            Console.WriteLine("menu");
            Console.WriteLine("1 - new game");
            Console.WriteLine("2 - load game");
            Console.WriteLine("3 - options");
            Console.WriteLine("4 - quit");
            Console.WriteLine("**************");
            Console.WriteLine();

            //promt for and get user choice
            Console.WriteLine("please enter a number shown");
            input = int.Parse(Console.ReadLine());
            //Console.WriteLine(input);
            if (input == 1 )
                {
                    Console.WriteLine("you have started a new game");
                }
            else if (input == 2 )
                {
                    Console.WriteLine("which game do you wish to load ");
                }
            else if (input == 3 )
                {
                    Console.WriteLine("the options are to:");
                }
            else if (input >= 5 || input < 1)
                {
                    Console.WriteLine("not a valid answer, renter a valid answer");
                }
            Console.WriteLine();
        }
        }
    }
}