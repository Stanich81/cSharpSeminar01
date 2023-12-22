// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// Console.Clear();
// Console.Write("Введите 1-е число ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-е число ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber == secondNumber * secondNumber)
// {
//     Console.WriteLine("Да, " + firstNumber + " является квадратом от " + secondNumber);
// }
// else
// {
//     Console.WriteLine("НЕТ, " + firstNumber + " НЕ является квадратом от " + secondNumber);
// }


// Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.

Console.Clear();
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
{
    n*=-1;
}
int negativeN = -n;
int i = 1;
while (negativeN <= n)
{
    Console.Write(negativeN + "\t" );
    negativeN++;
}
