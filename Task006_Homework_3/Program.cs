/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите любое число от 1 до 7");
int anyNumber = Convert.ToInt32(Console.ReadLine());
// Массив с текстом для вывода сообщений
string[] weekDayArray = {  "Понедельник",                  // 1 _ 0
                           "Вторник",                      // 2 _ 1
                           "Среда",                        // 3 _ 2
                           "Четверг",                      // 4 _ 3
                           "Пятница",                      // 5 _ 4
                           "Суббота",                      // 6 _ 5
                           "Воскресенье",                  // 7 _ 6
                           " рабочий",                     //   _ 7
                           " выходной",                    //   _ 8
                           " день",                        //   _ 9
                           "Вы ввели некорректное число",  //   _10
                           " это"};                        //   _11
                           
// Ниже ветвление определеяет и выводит условия задачи
if(anyNumber > 0 && anyNumber < 6) Console.WriteLine(weekDayArray[anyNumber - 1] + weekDayArray[11] + weekDayArray[7] + weekDayArray[9]);
else Console.WriteLine(weekDayArray[10]);
if(anyNumber == 6 || anyNumber == 7) Console.WriteLine(weekDayArray[anyNumber - 1] + weekDayArray[11] + weekDayArray[8] + weekDayArray[9]);