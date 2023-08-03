// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] get_composition(int[,] array1, int num11, int num12, int[,] array2, int num21, int num22)
{
    int[,] comp = new int[num11,num22];    
    for (int i=1;i<=num11;i++)
    {
        for (int j=1;j<=num22;j++)
        {
            for (int k = 1;k<=num12;k++)
            {
                comp[i-1,j-1]=comp[i-1,j-1]+array1[i-1,k-1]*array2[k-1,j-1];
            }
        }
    }    
    return comp;
}
Console.Write("Введите колличество строк 1 матрицы: ");
int arr_dim11 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов 1 матрицы: ");
int arr_dim12 = Convert.ToInt32(Console.ReadLine());
int[,] my_array1 = get_array(arr_dim11,arr_dim12);
output_array(my_array1, arr_dim11,arr_dim12);
Console.Write("Введите колличество строк 2 матрицы: ");
int arr_dim21 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов 2 матрицы: ");
int arr_dim22 = Convert.ToInt32(Console.ReadLine());
int[,] my_array2 = get_array(arr_dim21,arr_dim22);
output_array(my_array2, arr_dim21,arr_dim22);
int[,] rez = new int[arr_dim11,arr_dim22];
if (arr_dim12==arr_dim21)
{
    rez = get_composition(my_array1, arr_dim11,arr_dim12,my_array2, arr_dim21,arr_dim22);
    output_array(rez, arr_dim11,arr_dim22);
}
else
{
    Console.WriteLine("Умножение матриц невозможно.");
}