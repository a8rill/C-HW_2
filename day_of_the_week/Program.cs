// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите  цифру от 1 до 7:");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 & day <= 5)
{
    Console.WriteLine("Будний день");
}

else if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной  день");
}
else 
{
    Console.WriteLine("Вы ввели  несуществующий  день  недели. Попробуйте  еще  раз!"); 
}