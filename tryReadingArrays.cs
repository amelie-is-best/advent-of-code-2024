using System;

using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "data.csv";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: File not found.");
            return;
        }

        int[,] matrix = new int[3,3];
        //defines
        string[] lines = File.ReadAllLines(filePath);
        //reads lines from file
        for(int i = 0; i < lines.Length; i++) //parse lines into 2d array
        {
            string[] values = lines[i].Split(','); //split by commas

            for (int j = 0; j < values.Length; j++) //loops through values of the line
            {
                matrix[i,j] = int.Parse(values[j]); //convert + store
            }
        }
        Console.WriteLine("The contents of the matrix are:");
        for (int i = 0; i < matrix.GetLength(0); i++) //rows
        {
            for (int j = 0; j < matrix.GetLength(1); j++) //columns
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

