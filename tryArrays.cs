using System;

int[] numbers = {1,2,3,4,5,6,7};

numbers[0] = 1;//assigns values to positions
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;
numbers[5] = 6;
numbers[6] = 7;

int[] myArray = new int[5]; //space for 5 ints, all values = 0

Console.WriteLine(numbers[5]); //prints 6
Console.WriteLine(numbers[0]); //prints 1




int[] numbersLoop = {10,20,30,40,50};

for (int i = 0; i < numbersLoop.Length; i++) //numbers.Length is the size of array (in this case 5)
{
    Console.WriteLine(numbersLoop[i]);
}




int[] numbersAdd = { 10, 20, 30, 40, 50 };
int sum = 0;

for (int i = 0; i < numbersAdd.Length; i++) //adds them up
{
    sum += numbersAdd[i];
}

Console.WriteLine($"Total sum: {sum}");




int[,] matrix = new int[2, 3]; //2d arrays 2 rows & 3 columns
matrix[0, 0] = 1; //first row first column
matrix[0, 1] = 2;
matrix[1, 2] = 3;

Console.WriteLine(matrix[1, 2]);



int[,] matrix1 = { {1, 2, 3}, {4, 5, 6} }; //123 is row 456 is column

for(int i = 0; i < 2; i++) //loop rows
{
    for(int j = 0; j < 3; j++) //loop columns
    {
        Console.Write(matrix1[i, j] + " "); //access elements
    }
    Console.WriteLine();
}



Console.ReadLine();