// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetDistance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double distance = Math.Sqrt(Math.Pow((xb-xa), 2) + Math.Pow((yb-ya), 2) + Math.Pow((zb-za), 2) );
    distance = Math.Round(distance, 2);
    return distance;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int xa = GetInput("Введите координаты XA: ");
int ya = GetInput("Введите координаты YA: ");
int za = GetInput("Введите координаты ZA: ");
int xb = GetInput("Введите координаты XB: ");
int yb = GetInput("Введите координаты YB: ");
int zb = GetInput("Введите координаты ZB: ");

Console.WriteLine($"A ({xa},{ya},{za}); B ({xb},{yb},{zb}) -> {GetDistance(xa, ya, za, xb, yb, zb)};");   