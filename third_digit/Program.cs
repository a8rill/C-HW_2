// Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.

// 78 -> третьей цифры нет

// 3267900 -> 6


Console.WriteLine("Введите  положительное семизначное число:");
string number = Convert.ToString(Console.ReadLine());
int length = number.Length;
int index = 2;
int index_1 = 4;
int number_int = Int32.Parse(number);


if (number_int <= 0)
{
    Console.WriteLine("Вы ввели отрицательное  число. Попробуйте  еще раз!");
}
else if (length !=7)
{
    Console.WriteLine(" Вы ввели не  семизначное  число. Попробуйте  еще раз!");
}
else if (number_int <= 0 & length<4)
{ 
    Console.WriteLine("Нет третьей цифры. Попробуйте  еще раз!");
  }
else if ( length == 7)
{
    Console.WriteLine($"Третья  цифра слева числа {number}: {number[index]} ");
    Console.WriteLine($"Третья  цифра справа числа {number}: {number[index_1]} ");
}

 
 
