/*
Задача 1
Сгенерировать массив из N целых чисел от 1 до 100.. Выведите на экран
элементы, кратные трём и пяти, но не кратные семи
*/

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Console.Write(" элементы, кратные трём и пяти, но не кратные семи в массиве -" );


for (int i =0; i< N; i++)
{
    array[i] = new Random().Next(1, 100);
Console.Write( " "+(array[i]) );
}


for (int i =0; i< N; i++)
{
    if (array[i] % 3 == 0 && array[i] % 5 == 0 && array[i] % 7 > 0)
    {
         Console.WriteLine($" ===> {array[i]}"); 
            
    }
  
}    


 
