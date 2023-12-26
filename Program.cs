// Напишите программу, которая на вход принимает два целых числа и проверяет,
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

// Console.Clear();
// Console.Write("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n < 0)
// {
//     n*=-1;
// }
// int negativeN = -n;
// int i = 1;
// while (negativeN <= n)
// {
//     Console.Write(negativeN + "\t" );
//     negativeN++;
// }


// Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа:
// 456 => 10
// 782 => 9
// 918 => 17

// Console.Clear();
// Console.Write("Введите трёхзначное число ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n > 999 || n < 100)
// {
//     Console.Write("Вы ввели некорректное число. Повторите попытку");
//     return;
// }
// int n1 = n / 100;
// int n3 = n % 10;
// Console.WriteLine(n1 + n3);

// int number = 18;
// int i = 2;
// while (i <= number)
// {
// Console.Write(i + "\t");
// i=i+2;
// }

// int number = 12;
// int i = 1;
// while (i <= number)
// {
//     if ((i%2) == 0)
//     {
//         Console.Write(i + "\t");
//     }
// i++;
// }

// Console.Clear();
// Console.WriteLine("Введите трёхзначное число : ");
// int a = Convert.ToInt32(Console.ReadLine());
// int a1 = a / 100;
// int a2 = (a % 100) / 10;
// int a3 = a % 10;

// Console.WriteLine(a1 * 10 + a3);


// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1
// Console.Clear();
// Console.WriteLine("Введите трёхзначное число : ");
// int a = Convert.ToInt32(Console.ReadLine());
// int a1 = a / 100;
// int a2 = (a % 100) / 10;
// int a3 = a % 10;
// Console.WriteLine($"{a1} в степени {a3} = {Math.Pow(a2, a3)}");


//..Вывеси третью цифру слева от люого вводимого числа:
// Console.Clear();
// Console.WriteLine("Введите число : ");
// int a = Convert.ToInt32(Console.ReadLine());
// int copyA = a;
// if (a <= 99)
// {
//     Console.WriteLine("Введеное число меньше трёхзначного или отрицательное");
// }
// else{
// while (a >= 1000)
// {
//     a /= 10;
// }
// Console.WriteLine($"третья цифра слева от числа {copyA} = {(a % 10)}");
// }


// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Clear();
Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
int copyA = a;
if (a <= 99)
{
    Console.WriteLine("Введеное число меньше трёхзначного или отрицательное");
}
else
{
    a = a / 100 % 10;
    Console.WriteLine($"третья цифра справа от числа {copyA} = {a}");
}