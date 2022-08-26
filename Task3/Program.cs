// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

string Cub (int N)
{
    string b = "";
    int i = 1;
    while (i <= N)
    {
        b1 = b + (i * i * i);
        i++;
    } 
    return(b1);  
}

try
{
    Console.WriteLine("Enter number N: ");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine(Cub(N));
}
catch
{
    Console.WriteLine("You should enter numbers");
}