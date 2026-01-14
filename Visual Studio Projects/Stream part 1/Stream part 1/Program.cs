using System.Formats.Tar;

namespace Stream_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many files do you want to make?");
            int input = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine("Starting Spammer - 3 seconds remaining");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Starting Spammer - 2 seconds remaining");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Starting Spammer - 1 second remaining");
            Thread.Sleep(1000);
            Console.Clear();


            while (input >= 1)
            {
                Console.WriteLine("{0} files remaining", input);
                Thread.Sleep(20);
                Console.Clear();

                StreamWriter writer;


                writer = new StreamWriter($"{input}.txt");
                writer.WriteLine("hello world");
                writer.Close();
                StreamReader reader = new StreamReader("test.txt"); while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                }
                reader.Close();

                input--;
            }
        }

    }
}
