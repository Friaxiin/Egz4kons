namespace Egz4kons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];

            Random rand = new Random();

            Console.WriteLine("Liczby: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next();
                Console.Write(numbers[i] + " ; ");
            }
            Console.WriteLine();
            BubbleSort(numbers);

        }
        static void BubbleSort(int[] numbers)
        {
            int tmp = 0;
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j+1])
                    {
                        tmp = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j+1] = tmp;
                    }
                }
            }
            Console.WriteLine("Liczby posortowane:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ; ");
            }
        }
    }
}
