// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

// √ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2.

 double Distance3D (int xa,int ya,int xb, int yb, int za, int zb)
 {
     return Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2)+Math.Pow((zb - za),2));  
 }
   try 
   {
    Console.WriteLine("Введите координату х в точке а: ");
    int xa = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату у в точке а");
    int ya = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату х в точке b: ");
    int xb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату у в точке b");
    int yb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату z в точке а: ");
    int za = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату z в точке b: ");
    int zb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine (Distance3D(xa,ya,xb,yb,za,zb));
   }
   catch
   {
    Console.WriteLine (" Нужно вводить другие координаты, координаты должны быть целыми числами ");
   }
