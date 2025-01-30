using System;

internal class Program
{
    static int Sum(int n)
    {
        int sum = 0;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
            sum += arr[i];
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Sum of Numbers in an Array");
        System.Console.WriteLine("\nSumming 1 to n");
        Console.Write("Type length of array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nSum is " + Sum(n));
        Console.ReadKey();
    }
}
