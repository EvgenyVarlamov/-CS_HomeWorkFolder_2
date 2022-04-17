/* Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает.
Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
Доп. задача с усложнением: на отгадывание дается 3 попытки. */

int numberRandom = new Random().Next(1, 11);    // Программа загадывает случайное число
// Массив с текстом для вывода сообщений
string[] textArray = { "Здравствуйте, вам выпала уникальная возможность принять участие в игре <Угадайка>",      // 00
                       "Если вы желаете принять в ней участие, введите <yes>, если не желаете, введите <no>",    // 01
                       "Вам нужно угадать загаданное число",                                                     // 02
                       "Для этого у вас есть три попытки",                                                       // 03
                       "Введите любое число от 1 до 10",                                                         // 04
                       "Вы не угадали, загаданное число меньше, введите еще раз",                                // 05
                       "Вы не угадали, загаданное число больше, введите еще раз",                                // 06
                       "У вас осталось попыток: ",                                                               // 07
                       "Вы не угадали загаданное число, оно равнялось ",                                         // 08
                       "Поздравляю, вы угадали загаданное число",                                                // 09
                       "До свидания.",                                                                           // 10
                       "yes" };                                                                                  // 11

Console.WriteLine(textArray[0]);
Console.WriteLine(textArray[1]);
string? checkValue = Console.ReadLine();
int index = 2;

// Проверка введенных данных на соответствие условия задачи
if(checkValue == textArray[11])
{
    Console.WriteLine(textArray[2]);
    Console.WriteLine(textArray[3]);
    Console.WriteLine(textArray[4]);
    int yourNumber = Convert.ToInt32(Console.ReadLine());

    if(yourNumber == numberRandom) Console.WriteLine(textArray[9]);

    else
    {        
        while(index > 0)
        {
            Console.WriteLine(textArray[7] + index);
            index--;
            if(yourNumber > numberRandom)
            {
                Console.WriteLine(textArray[5]);
            }
            if(yourNumber < numberRandom)
            {
                Console.WriteLine(textArray[6]);
            }

            yourNumber = Convert.ToInt32(Console.ReadLine());
            if(yourNumber == numberRandom)
            {
                Console.WriteLine(textArray[9]);
                index =0;
            } 
            if(yourNumber != numberRandom && index == 0) Console.WriteLine(textArray[8] + numberRandom);
        }
        
    }
}
else
{
    Console.WriteLine(textArray[10]);
}