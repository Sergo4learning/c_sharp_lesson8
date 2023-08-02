// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
int[,] get_sorted(int[,] array, int num1, int num2)
{
    int[,] new_array = new int [num1,num2];
    for (int i=1;i<=num1;i++)
    {
        for (int j=1;j<=num2;j++)
        {
            int temp=0;
            for (int k=1;k<=j;k++)
            {
            if(array[i-1,j-1]>array[i-1,k-1])
                {
                    temp = array[i-1,j-1];
                    array[i-1,j-1]= array[i-1,k-1];
                    array[i-1,k-1]= temp;
                }                
            }
        }
    }    
    new_array=array;
    return new_array;
}
Console.Write("Введите колличество строк массива: ");
int arr_dim1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: ");
int arr_dim2 = Convert.ToInt32(Console.ReadLine());
int[,] my_array = get_array(arr_dim1,arr_dim2);
output_array(my_array, arr_dim1,arr_dim2);
Console.WriteLine("");
int[,] rez_array = get_sorted(my_array, arr_dim1,arr_dim2);
output_array(rez_array, arr_dim1,arr_dim2);