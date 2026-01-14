namespace starter_convert_minutes_into_seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input minutes");
            int input = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(500);
            Console.Clear();

            convert(input);
        }

        static void convert(int input)
        {
            int result = 0;

            result = (input / 60);

            Console.WriteLine(result);
        }
    }
}
