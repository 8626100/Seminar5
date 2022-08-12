//Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите левую границу массива");
int leftRange = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите правую границу массива");
int rightRange = Convert.ToInt32(Console.ReadLine());

Random rand = new Random ();
int[] arr = new int [size];

for (int i = 0; i < arr.Length; i++)
{
    arr [i] =rand.Next(leftRange,rightRange+1);
   
}
Console.WriteLine(string.Join(",",arr));

int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 9 & arr[i] < 100)
    {
        sum++;
    }
}
Console.Write($"{sum} элементов массива принадлежат отрезку [10,99]");