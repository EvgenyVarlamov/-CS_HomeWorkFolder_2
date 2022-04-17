/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если число 2 не кратно числу 1, то программа выводит остаток от деления. Использовать функцию.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно*/

Console.WriteLine("Проверка на кратность двух чисел к первому");
Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

string messageFinal = CheckTwoNumbersFunction(firstNumber, secondNumber);
Console.WriteLine(messageFinal);

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
string CheckTwoNumbersFunction(int numberFirst, int numberSecond) // Функция проверки на кратность двух чисел к первому числу  //
  {                                                                                                                            //
    string message;                                                                                                            //
    int result = numberSecond % numberFirst;                                                                                   //
    if(result == 0) message = ("Числа " + numberFirst + " и " + numberSecond + " кратны");                                     //
    else message = ("Числа " + numberFirst + " и " + numberSecond + " не кратны, остаток равен " + result );                   //
    return message;                                                                                                            //
  }                                                                                                                            //
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////