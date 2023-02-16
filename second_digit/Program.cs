// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите  трехзначное положительное число:");
string number = Convert.ToString(Console.ReadLine());
int length = number.Length;
int number_int = Int32.Parse(number);
if (number_int <= 0)
{
    Console.WriteLine("Вы ввели отрицательное  число");
}
else if (length != 3)
{
    Console.WriteLine("Вы ввели не  трехзначное  число");
}

else if (length == 3)
{

    int result = (number_int / 10) % 10;
    Console.WriteLine($"Вторая  цифра числа {number_int}: {result}");
}

