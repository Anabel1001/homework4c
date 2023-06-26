//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//int leftRange, int rightRange

void FillArray(int[] array)
{
    Random rand = new Random(); 
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = rand.Next(0,100);
    }
}

void PrintArray(int[] array, string separator)
{    
    System.Console.Write("[" +string.Join(separator, array) + "]");
}
int [] array = new int [8];
FillArray(array);
PrintArray(array, ", ");
