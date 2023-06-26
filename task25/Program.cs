// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Vozv(int mainnum, int secnum){
  int result = 1;
  for(int i=1; i <= secnum; i++)
  {
    result = result * mainnum;
  }
        return result;
}

int mainnum = ReadInt("Введите число, которое нужно возвести: ");
int secnum = ReadInt("Введите число, в которое нужно возвести: ");
int res = Vozv(mainnum, secnum);
System.Console.WriteLine("Ответ: " + res);