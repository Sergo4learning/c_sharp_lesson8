// *Задача 62**. * Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void output_num(int num)
{
    if (num<10)
    {
        Console.Write(0);
        Console.Write(num+" ");
    }
    else
    {
        Console.Write(num+" ");
    }
}
void output_array(int[,] arr, int num1, int num2)
{
    for (int i=1; i<=num1;i++)
    {
        for (int j=1; j<=num2; j++)
        {
            output_num(arr[i-1,j-1]);
        }
        Console.WriteLine("");
    }    
}
int[,] spiral(int num1, int num2)
{
    int[,] new_array = new int[num1,num2];    
    int n=1;    
    int start1=1;
    int start2=1;
    int counter=0;        
    while (n<num1*num2)
    {
        for (int j=start2;j<=num2-counter;j++)
        {
            new_array[start1-1,j-1]=n;
            n++;
        }
        n--;
        start2=num2-counter;
        for (int i=start1;i<=num1-counter;i++)
        {
            new_array[i-1,start2-1]=n;
            n++;
        }
        n--;        
        start1=num1-counter;
        for (int j=start2;j>0+counter;j--)
        {
            new_array[start1-1,j-1]=n;
            n++;
        }
        n--;        
        counter++;
        start2=counter;
        for (int i=start1;i>0+counter;i--)
        {
            new_array[i-1,start2-1]=n;
            n++;
        }   
        n--;          
        start1=counter+1;
    }
    return new_array;
}
Console.Write("Введите колличество строк матрицы: ");
int arr_dim1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов матрицы: ");
int arr_dim2 = Convert.ToInt32(Console.ReadLine());
int[,] my_array = spiral(arr_dim1, arr_dim2);
output_array(my_array, arr_dim1,arr_dim2);