// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


void Cub(int[]massiv1)
{
    int size = massiv1.Length;
    int i = 1;
    while(i < size)
    {
        massiv1[i] = (i * i *i);
        i++;
    }
}
void PrintArray (int[]massiv)
{
    int length = massiv.Length;
    int index = 1;
    while (index < length)
    {
        Console.WriteLine(massiv[index] + " ");
        index++;
    }
}
try
{
    
    Console.Write("Введите число ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[]cub = new int[N+1];
    Cub(cub);
    PrintArray(cub);
}

catch
{
    Console.WriteLine(" The number N should be > 0 and should be integer number");
}
