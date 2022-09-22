// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[] GetArray(int size, int leftRange, int rightRage)
{
    int[] arr = new int[size]; 
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRage + 1);
    }
    return arr;
}

int[] arr = GetArray(5, 0, 10);
int[] copyArray = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    copyArray[i] = arr[i];
}
//arr[0] = -1000;

Console.WriteLine($"Исходный массив = {string.Join(", ", arr)}");
Console.WriteLine($"Скопированный массив = {string.Join(", ", copyArray)}");

// int a = 1;
// int b = a;

// a = 6;
// Console.WriteLine(a);
// Console.WriteLine(b);