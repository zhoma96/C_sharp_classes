// int SumFromOneToN(int n)
// {
//     if (n < 1)
//         return -1;
//     int result = 0;
//     int counter = 1;
//     while(counter <= n)
//     {
//         result += counter;
//         counter++;
//     }
//     return result;
// }

// Console.WriteLine("Enter digit: ");
// int.TryParse(Console.ReadLine(), out int n);

// if (n < 1) {
//     Console.WriteLine("Число должно быть положительным");
//     return;
// }


// int result = SumFromOneToN(n);
// Console.WriteLine(result);

// -------------------------------------------------------------------------------------

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int DigitCount(int n)
// {
//     if (n < 1)
//         n = Math.Abs(n);
//     int counter = 0;
//     if (n == 0)
//         n = 1;
//     while(n > 0)
//     {
//         n /= 10;
//         counter++;
//     }
//     return counter;
// }

// Console.WriteLine("Enter number: ");
// int.TryParse(Console.ReadLine(), out int n);


// int result = DigitCount(n);
// Console.WriteLine(result);

// --------------------------------------------------------------------------

// Задача 28: Напишите программу, которая принимает на вход число 
// N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int MultFromOneToN(int n)
// {
//     if (n < 1)
//         return -1;
//     int res = 1;
//     int counter = 1;
//     while(counter <= n)
//     {
//         res *= counter;
//         counter++;
//     }
//     return res;
// }

// Console.WriteLine("Enter digit: ");
// int.TryParse(Console.ReadLine(), out int n);

// if (n < 1) {
//     Console.WriteLine("Число должно быть положительным");
//     return;
// }


// int result = MultFromOneToN(n);
// Console.WriteLine(result);

// ---------------------------------------------------------------------

// Задача 30: Напишите программу, которая выводит массив из 
// 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


void FillArray(int[] col)
{
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        col[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int[] array = new int[100];
FillArray(array);
PrintArray(array);