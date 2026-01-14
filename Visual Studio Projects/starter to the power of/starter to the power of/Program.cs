namespace starter_to_the_power_of
{
    internal class Program
    {
        static void Main(string[] args)
        {
            СalculateExponent(2, 1); // = 2
            СalculateExponent(2, 2); // = 2*2
            СalculateExponent(2, 3); //= 2*2*2 (3 twos all *)\
            СalculateExponent(3, 2); // = 3*3
            СalculateExponent(3, 4); // = 3*3*3*3 (4 threes all * )
            СalculateExponent(7, 3); // ➞ 343
            СalculateExponent(3, 4); // ➞ 81
        }

        static void СalculateExponent(int first, int second)
        {
            double result = 0;

            result = Math.Pow(first, second);

            Console.WriteLine(result);
        }
    }
}
