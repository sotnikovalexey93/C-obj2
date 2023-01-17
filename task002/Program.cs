/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine ("Введите люое число число");
string NumberStr1 = Console.ReadLine();
int number = Convert.ToInt32 (NumberStr1);
int i = number.ToString().Length;

if (i>2)
{
    Console.WriteLine(NumberStr1[2]);
}          
else
{
   Console.WriteLine("Третьей цифры нет"); 
} 

