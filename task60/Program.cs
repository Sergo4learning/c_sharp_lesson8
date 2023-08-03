// Задача 60. . ..Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Random rnd = new Random((int)DateTime.Now.Ticks);
int[,,] get_array(int num1, int num2, int num3)
{
    int[,,] new_array = new int[num1,num2,num3];    
    for (int i = 1; i<=num1; i++)
    {
        for (int j=1; j<= num2;j++)
        {
            for (int k=1;k<=num3;k++)
            {
                new_array[i-1,j-1,k-1] = rnd.Next(0,100);
            }
            
        }        
    }    
    return new_array;
}
void output_array_with_coord(int[,,] arr, int num1, int num2, int num3)
{
    for (int i=1; i<=num1;i++)
    {
        for (int j=1; j<=num2; j++)
        {
            for (int k=1;k<num3;k++)
            {
                Console.Write(arr[i-1,j-1,k-1]+"("+(i-1)+","+(j-1)+","+(k-1)+") ");
            }
        Console.WriteLine(arr[i-1,j-1,num3-1]+"("+(i-1)+","+(j-1)+","+(num3-1)+") ");            
        }
    }    
}
Console.Write("Введите колличество строк массива: ");
int arr_dim1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: ");
int arr_dim2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество страниц массива: ");
int arr_dim3 = Convert.ToInt32(Console.ReadLine());
int[,,] my_array = get_array(arr_dim1,arr_dim2,arr_dim3);
output_array_with_coord(my_array,arr_dim1,arr_dim2,arr_dim3);