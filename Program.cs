// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



// Console.WriteLine("Введите трёхзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number < 100 || number >= 1000)
// {
//     Console.WriteLine(number + " не является трёхзначным числом");

// }
// else
// {
//     int num = ((number % 100) - (number % 10)) / 10;
//     Console.WriteLine($"Вторая цифра числа {number} является {num}");
// }






//__________________________________________________________________



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number < 100)
// {
//     Console.WriteLine($"В {number} числе нет третьей цифры");    
// }
// else
// {
//     if(number > 999)
//     {
//     int num1 = number;
//     while(num1 > 999)
//     {
//         num1 = (num1 / 10);
//     }
//     int num2 = (num1 % 10);
//     Console.WriteLine($"(первый)Третья цифра числа {number} является {num2}");
//     }
//     if(number > 99 && number < 1000)
// {
//     int num = (number % 10);
//     Console.WriteLine($"(второй)Третья цифра числа {number} является {num}");
// }
// }



//__________________________________________________________________




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите номер дня");
// int number = Convert.ToInt32(Console.ReadLine());
// int num = number;
// if(number > 0 && number < 6)
// {
//     Console.WriteLine($"{number} Не выходной!");
// }
// else if(number > 5 && number < 8)
// {
//     Console.WriteLine($"{number} УРААА выходной!!!!");
// }

// else
// {
// Console.WriteLine($"{num} Это не день недели");
// }


