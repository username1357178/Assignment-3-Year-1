namespace starter_using_the____operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool choicebool1 = false;
            bool choicebool2 = false;

            Console.WriteLine("Select your first true or false");
            Console.WriteLine();
            Console.WriteLine("[1]. True");
            Console.WriteLine("[2]. False");
            Console.WriteLine();
            Console.Write("Enter your decision here: ");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            if (choice1 == 1)
            {
                choicebool1 = true;
            }
            else if (choice1 == 2)
            {
                choicebool1 = false;
            }
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine("Select your second true or false");
            Console.WriteLine();
            Console.WriteLine("[1]. True");
            Console.WriteLine("[2]. False");
            Console.WriteLine();
            Console.Write("Enter your decision here: ");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            if (choice2 == 1)
            {
                choicebool2 = true;
            }
            else if (choice2 == 2)
            {
                choicebool2 = false;
            }
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(choicebool1 && choicebool2);
        }
    }
}
