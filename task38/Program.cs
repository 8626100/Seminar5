//Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//Задать размер (int) массива с клавиатуры
//[3 7 22 2 78] -> 76



Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
double[] a = new double[N];
for(int i = 0;i<N;i++)
{
Console.WriteLine("Введите {0}-й элемент", i+1);
a[i] =Convert.ToDouble(Console.ReadLine()) ;
}
Console.WriteLine('[' + string.Join(",", a) + ']');
 double Max = a[0]; double Min = a[0]; 
for (int i = 0; i < N; i++)
{
    if (a[i] > Max)
    {
        Max = a[i];
    }
    if (a[i] < Min)
    {
        Min = a[i];
    }
}
 double difference = Max - Min;
Console.WriteLine($"Разница между максимальным {Max} и минимальным {Min} элементами массива = {difference}");