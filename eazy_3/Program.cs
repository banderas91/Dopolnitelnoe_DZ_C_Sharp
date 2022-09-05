/*
Задача 3
Сгенерировать массив из N целых чисел от -100 до 100. Выясните,
содержатся ли в массиве отрицательные числа. На экран вывести только ответ:
«Да» или «Нет».
*/
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Console.Write(" содержатся ли отрицательные числав массиве --->" );
 int count = 0;
 int i = 0;
for ( i =0; i< N; i++)
{
    array[i] = new Random().Next(-100, 100);
Console.Write( " "+(array[i]) );
}


for (i =0; i< N; i++)
{
  if (array[i] < 0 )
    {
  count++;
      
    }
}

 
if (count > 0)
{
 Console.WriteLine(" ДА"); 

}
 
 if (count == 0)
 {
     Console.WriteLine(" НЕТ"); 
 }
   
    