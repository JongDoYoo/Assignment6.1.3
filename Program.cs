namespace Assignment6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 7, 1, 0, 1, 0, 0, 4, 7 };

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    array[count]= array[i];
                    count++;
                }
            }
            while (count < array.Length)
            {
                array[count] = 0;
                count++;
            }
            foreach (int i in array)
            {
                Console.Write(i+" ");
            }


        }
    }
}
