/*
Задача 2
Сгенерировать массив из N целых чисел от -100 до 100. Выведите на
экран количество положительных чисел и их сумму.
*/
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Console.Write(" эколичество положительных чисел и их сумма в массиве --->" );


for (int i =0; i< N; i++)
{
    array[i] = new Random().Next(-100, 100);
Console.Write( " "+(array[i]) );
}

int sum = 0;
int count = 0;
for (int i =0; i< N; i++)
{
    if (array[i] > 0 )
    {
        count++;
        sum = sum + array[i];
            
    }

}    
Console.WriteLine($" Сумма ===> {sum}, Количество положительных чисел {count}"); 
