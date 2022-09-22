// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// задача с рекскурсией

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void printBinaryView(int number)
{
    if (number <= 0) return;
    printBinaryView(number / 2); 
    Console.Write(number % 2);
}

int num = ReadNumber("Введите число: ");
printBinaryView(num);