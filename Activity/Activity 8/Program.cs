using System;
using System.Collections.Generic;
using System.Linq;

class Activity_8 {

    public static void Main()
    {

        int[] arr1 = new int[5];
        int[] arr2 = new int[5];
        int i;
        HashSet<string> hashset1 = new HashSet<string>();

        hashset1.Add("1");
        hashset1.Add("2");
        hashset1.Add("3");
        hashset1.Add("4");
        hashset1.Add("5");

        Console.WriteLine("===HashSet 1===");
        for(i = 0; i < arr1.Length; i++)
        {
        Console.Write("Element {0} : ",i);
        arr1[i] = Convert.ToInt32(Console.ReadLine());       
      }
        HashSet<string> hashset2 = new HashSet<string>();
        hashset2.Add("2");
        hashset2.Add("4");
        hashset2.Add("6");
        hashset2.Add("8");
        hashset2.Add("10");

        Console.WriteLine("\n");
        Console.WriteLine("===HashSet 2===");
        for(i = 0; i < arr1.Length; i++)
        {
        Console.Write("Element {0} : ",i);
        arr1[i] = Convert.ToInt32(Console.ReadLine());       
      }
        var resultUnion = hashset1.Union(hashset2);
        var resultIntersect = hashset1.Intersect(hashset2);
        var resultExcept = hashset1.Except(hashset2);

        Console.Write("\nUNION: ");
        foreach (var item in resultUnion)
        {
            Console.Write(item + " ");
        }

        Console.Write("\nINTERSECTION: ");
        foreach (var item in resultIntersect)
        {
            Console.Write(item + " ");
        }

        Console.Write("\nSET DIFFERENCE: ");
        foreach (var item in resultExcept)
        {
            Console.Write(item + " ");
        }
        Console.ReadKey();
    }
}