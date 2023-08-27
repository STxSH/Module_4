namespace Task_4_3_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int numbers = 0;

            foreach (int i in arr) if (i > 0) numbers++;

            Console.WriteLine("Количество положительных чисел в массиве: " + numbers);
        }
    }
}