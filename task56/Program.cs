// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Random rnd = new Random();
int[,] get_array(int num1, int num2)
{
    int[,] new_array = new int[num1,num2];    
    for (int i = 1; i<=num1; i++)
    {
        for (int j=1; j<= num2;j++)
        {
            new_array[i-1,j-1] = rnd.Next(0,10);
        }        
    }    
    return new_array;
}
void output_array(int[,] arr, int num1, int num2)
{
    for (int i=1; i<=num1;i++)
    {
        for (int j=1; j<num2; j++)
        {
            Console.Write(arr[i-1,j-1]+" ");
        }
        Console.WriteLine(arr[i-1,num2-1]);
    }    
}
int get_num_row(int[,] array, int num1, int num2)
{
    int[] summ = new int[num1];    
    int min = 0;
    int k = 1;
    for (int i=1;i<=num1;i++)
    {
        for (int j=1;j<=num2;j++)
        {
            summ[i-1]=summ[i-1]+array[i-1,j-1];
        }
        if (i==1)
        {
            min=summ[i-1];
        }
        else
        {
            if (min>summ[i-1])
            {
                min=summ[i-1];
                k = i;
            }
        }
    }    
    return k;
}
Console.Write("Введите колличество строк массива: ");
int arr_dim1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: ");
int arr_dim2 = Convert.ToInt32(Console.ReadLine());
int[,] my_array = get_array(arr_dim1,arr_dim2);
output_array(my_array, arr_dim1,arr_dim2);
int rez = get_num_row(my_array, arr_dim1,arr_dim2);
Console.WriteLine(rez+" строка");