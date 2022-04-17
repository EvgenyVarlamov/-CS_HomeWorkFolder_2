/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
546 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите любое число не более 10 знаков");
int anyNumber = Convert.ToInt32(Console.ReadLine());

string resultMessage = ThirdDigitShowFunction(anyNumber);
Console.WriteLine(resultMessage); //Вывод с помощью функции/метода третьей цифры числа, если она есть.

//////////////////////////////////////////////////////////////////////////////////////////////////////////////
string ThirdDigitShowFunction(int digitThree) // Функция/метод выделения третьей цифры числа, если она есть.//
{                                                                                                           //
  int preresult = digitThree % 1000 / 100;                                                                  //
  int index = 0;                                                                                            //
  string message;                                                                                           //
                                                                                                            //
  while(digitThree > 0)                                                                                     //
  {                                                                                                         //
      digitThree = digitThree / 10;                                                                         //
      index++;                                                                                              //
  }                                                                                                         //
                                                                                                            //
  if(index >= 3) message = ("Третья цифра введённого числа: " + preresult);                                 //
  else message = ("Третьей цифры в введённом числе нет");                                                   //
  return message;                                                                                           //
}                                                                                                           //
//////////////////////////////////////////////////////////////////////////////////////////////////////////////
