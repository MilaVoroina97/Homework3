// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

string Palindrom (string x)
{ 
    int y = int.Parse(x); 
    if (y >= 10000 && y < 100000)
    {
        if (x[0] == x[4] && x[1] == x[3]) return " This is a palindrom";
        else return "This is NOT a palindrom";    
    }
    else return "You should enter a five-digit number";
}
 try
 {
    Console.WriteLine(" Enter a five - digit number");
    string x = Console.ReadLine();
    Console.WriteLine(Palindrom(x));
 }
 catch 
 {
    Console.WriteLine("You should enter a five-digit number!!!");

 }

    
