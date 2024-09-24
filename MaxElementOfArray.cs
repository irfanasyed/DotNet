namespace MaxElementOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greatest1 = 0,greatest2=int.MinValue,greatest3=int.MinValue;
            Console.WriteLine("enter the element");
            int[] array= new int[10];
            int i;
            for (i = 0; i < array.Length; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());

            }
            for ( i = 0;i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            greatest1 = array[0];
            for ( i = 0; i < array.Length - 1; i++)
            {
                
                    
                if (greatest1 < array[i])
                {
                    greatest3 = greatest2;
                    greatest2 = greatest1;
                    greatest1= array [i];
                }
                else if (array[i] > greatest2)
                {
                    greatest3 = greatest2;
                    greatest2 = array[i];
                }
                else if (array[i] > greatest3)
                {
                    greatest3 = array[i];
                }


            }
            Console.WriteLine("the 1st greatest of  arary"+ greatest1);
            Console.WriteLine("the  2nd greatest of  arary" + greatest2);
            Console.WriteLine("the 3rd greatest of  arary" + greatest3);


        }
    }
}
