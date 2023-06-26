// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int SumNumber(int number)
{
    int counter = Convert.ToString(number).Length;
    int ost = 0;
    int res = 0;

    for (int i = 0; i < counter; i++){
      ost = number - number % 10;
      res = res + (number - ost);
      number = number / 10;
    }
   return res;
  }
//___________________________--код--__________________________
int number = ReadInt("Введите число: ");
int sum = SumNumber(number);
Console.WriteLine("Сумма всех цифр в числе: " + sum);
