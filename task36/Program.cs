//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int []FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
Random rand = new Random ();
int[] arr = new int [size];

for (int i = 0; i < arr.Length; i++)
{
    arr [i] =rand.Next(leftRange,rightRange+1);
   
}
return arr;
}
int [] arr = FillArrayWithRandomNumbers(5,1,100);
Console.WriteLine(string.Join(",",arr));
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
   if (i % 2 > 0)
   {
    sum = sum + arr[i];
    
   }

}
Console.Write($"Сумма элементов, стоящих на нечетных позициях, равна  - {sum}  ");