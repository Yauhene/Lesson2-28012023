﻿// Поиск индекса элемента с заданным значением

int[] array = {1,12,18,4,15,16,17,18};
int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine("index = " + index);
        break;
    }
    index++; // index=index+1
}
