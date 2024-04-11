using System;

class Solution
{

    public static int superDigit(string n, int k)
    {

        long sum = 0;
        foreach (char c in n)
        {
            sum += c - '0';  
        }
        sum *= k; 


        string sumString = sum.ToString();


        if (sumString.Length == 1)
        {
            return int.Parse(sumString);
        }

        return superDigit(sumString, 1);
    }

    public static void Main(string[] args)
    {

        string[] inputs = Console.ReadLine().Split();
        string n = inputs[0];
        int k = int.Parse(inputs[1]);

        int result = superDigit(n, k);

        Console.WriteLine(result);
    }
}