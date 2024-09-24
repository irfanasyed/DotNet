namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int count;
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("The array elements are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            for (int i = 0; i < array.Length; i++)
            {
                count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine($"Repeated element: {array[i]}, Count: {count}");
                }
                else
                {
                    Console.WriteLine($"Non-repeated element: {array[i]}, Count: {count}");

                }
            }
        }
    }
}
