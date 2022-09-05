/*
Задача 4
Сгенерировать массив из N целых чисел от 1 до 100. Вычислить
величину
𝐴
𝐺
, где A – среднее арифметическое среди всех элементов массива, а
G – среднее геометрическое.
*/

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Console.Write("в массиве --->" );


for (int i =0; i< N; i++)
{
    array[i] = new Random().Next(1, 100);
Console.Write( " "+(array[i]) );
}

double SrA = 0;
double SrG = 0;
int count = 0;
int pr =1;
for (int i =0; i< N; i++)
{
    SrA=SrA+array[i];
    count++;
}    
SrA =SrA / count;
Console.WriteLine(" Среднее арефметическое--->"+SrA); 
for (int i =0; i< N; i++)
{
    pr=pr * array[i];
    
}    
SrG = Math .Sqrt (pr);
Console.WriteLine("Среднее геометрическое--->"+SrG); 
Console.WriteLine("Отношение А/G--->"+(SrA / SrG)); 