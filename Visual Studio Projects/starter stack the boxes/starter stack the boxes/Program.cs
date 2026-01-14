namespace starter_stack_the_boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How high do you want the stack?");
            int input = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(500);
            Console.Clear();

            StackBoxes(input);
        }

        static void StackBoxes(int input)
        {
            double result = 0;

            result = Math.Pow(input, input);

            Console.WriteLine("To make the stack", result);
        }
    }
}
