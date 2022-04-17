﻿// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Нужно написать хотя бы 1 функцию.

int numberRandom = new Random().Next(100, 1000);                                            // Случайное число
int numberFirstAndThird = RandomFunction(numberRandom);                                     // Присвоение переменной трёхзначного числа без второй цифры

Console.WriteLine("Случайное трёхзначное число: " + numberRandom);
Console.WriteLine("Случайное трёхзначное число без второй цифры: " + numberFirstAndThird);  // Вывод случайного трёхзначного числа без второй цифры

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                                                                                                                                      //
int RandomFunction(int number)                                                              // Функция/метод, удаления из случайного трёхзначного числа второй цифры  //
{                                                                                                                                                                     //
    int digitFirst = number / 100;                                                                                                                                    //
    int digitThird = number % 10;                                                                                                                                     //
    int result = digitFirst*10 + digitThird;                                                                                                                          //
    return result;                                                                                                                                                    //
}                                                                                                                                                                     //
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////