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
            Console.WriteLine(input);
        }
        }
    }
}