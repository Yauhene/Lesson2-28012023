﻿// See https://aka.ms/new-console-template for more information

void FillArray(int[] collection)
{
    int Length = collection.Lenght;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
            Console.WriteLine(col[position]);
            position++;
    }
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);