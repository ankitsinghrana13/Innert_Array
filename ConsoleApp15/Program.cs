using System;
namespace Insert_array
{

    class program
    {

        static void Main(string[] arg)
        {

            int[] x = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter the array elelemnt");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("your insert array elements");
            foreach (int arr in x)
            {
                Console.WriteLine(arr);
            }
            Console.ReadLine();
        }
    }
}