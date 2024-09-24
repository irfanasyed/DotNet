namespace StringRepeatedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] arrayString = new string[7];
            Console.WriteLine("enter the string elements");
            
            for (int i=0;i<arrayString.Length;i++)
            {
                arrayString[i] = Console.ReadLine();
            }
            Console.WriteLine("the elements in string array");
            for (int i = 0; i < 7; i++)
            {
                Console.Write(arrayString[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0;i < 7; i++)
            {
                count = 0;
                for (int j = 1; j < 7; j++)
                {
                    if(arrayString[i]==arrayString[j])
                    {
                        count++;
                    }
                }
                if(count>1)
                {
                    Console.WriteLine($"element {arrayString[i]} count value is {count}");
                }
            }
        }
    }
}
