 using System;

    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
        Console.WriteLine("==ARRAY PROGRAM==");
        for (int i=0;i<5;i++)
        {
            Console.Write("Enter Element {0}: ", i );
            arr1[i] = Convert.ToInt32(Console.ReadLine());
         }
          int j=0, k=0;
            for (int i=0;i<arr1.Length;i++)
            {
                if ((arr1[i]%2)==0)
                {
                    arr2[j] = arr1 [i];
                    j++; 
                    
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }

            }
            Console.Write("Odd Numbers ");
            for (int i=0;i<k;i++)
            {
                Console.Write("{0}, ", arr3[i]);
            }
            Console.Write("\nEven Numbers ");
            for (int i =0; i<j;i++)
            {
                Console.Write("{0}, ", arr2[i] );
            }
         }
    }
