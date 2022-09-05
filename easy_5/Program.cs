/*
Задача 5
Сгенерировать массив из N целых чисел. Определить, есть ли в нем
элементы, равные среднему арифметическому среди всех элементов. Вывести
на экран ответ: «Да» или «Нет».
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

int SrA = 0;

int count = 0;
int count2 =0;
for (int i =0; i< N; i++)
{
    SrA=SrA+array[i];
    count++;
}    
SrA =SrA / count;
Console.WriteLine(" Среднее арефметическое--->"+SrA); 
for (int i =0; i< N; i++)
{
    if ( SrA== array[i])
    {
        count2++;
    }

    
}    

if (count2 >0)
{
    Console.WriteLine("YES"); 


}
else {
    Console.WriteLine("NO"); 

}

