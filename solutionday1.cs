using System;
using System.IO;
using System.Linq; // Required for sorting and LINQ operations

class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:\\Users\\ameli\\School\\2425 year 1\\WLC\\SW\\advent-of-code-2024\\input.txt"; // Path to the input file
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: File not found.");
            return;
        }

        // Reads all lines from the file
        string[] lines = File.ReadAllLines(filePath); // Every line of file is string - this is array of every line
        int length = lines.Length;

        int[] leftArray = new int[lines.Length];
        int[] rightArray = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++) //each line
        {
            string[] values = lines[i].Split("   "); // Split line by 3 spaces to get numbers in current line

            leftArray[i] = int.Parse(values[0]);
            rightArray[i] = int.Parse(values[1]);
        }

        Array.Sort(leftArray);
        Array.Sort(rightArray);

        int sum = 0;

        for (int i = 0; i < length; i++)
        {
            sum += Math.Abs(leftArray[i] - rightArray[i]);
        }

        Console.WriteLine(sum);
    }
}