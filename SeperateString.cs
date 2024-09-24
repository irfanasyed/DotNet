namespace SeperateString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            Console.WriteLine("the given string is"+str);
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                Console.Write(ch[i] + " ");
            }
        }
    }
}
