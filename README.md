🟢 **Task: Sum of Numbers in an Array**  

📌 This program calculates the sum of numbers from **1 to n**.  

🔹 **How it works:**  
1️⃣ The user enters a number **n** (the length of the array).  
2️⃣ The program creates an array with numbers from **1 to n**.  
3️⃣ It adds all these numbers together.  
4️⃣ Finally, it displays the total sum.  

📝 **Example:**  
Type length of array: 5
Sum is 15 (because 1 + 2 + 3 + 4 + 5 = 15)

```
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

```
