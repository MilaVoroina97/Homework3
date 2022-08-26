// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да
//string Palindrom(string x)
//{
    //if (x[0] == x[4] && x[1] == x[3])
    //{
        //Console.WriteLine(" This is a five-digit number");
    //}

    //return(x);
//}
//try
//{

    //Console.WriteLine("Enter a five-digit number");
    //string a = Console.ReadLine();
    //Console.WriteLine(Palindrom (a));
//}
//catch
//{
   // Console.WriteLine(" You entered not a five-digit number");
//}


// Second way:

void Palindrom()
{
    Console.WriteLine("Enter a five-digit number");
    string x = Console.ReadLine();
    int y = int.Parse(x); 
    if (y >= 10000 && y < 100000)
        if (x[0] == x[4] && x[1] == x[3])
        {
            Console.WriteLine(" This is a palindrom");
        }
        else
        {
            Console.WriteLine(" This is NOT a palindrom");
        }
    else
    {
        Console.WriteLine(" You should enter a five-digit number");
    }
}

Palindrom();
    
