// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string GetTableCubes(int range)
{
    double[] mas = new double[range];
    for (int i = 0; i < range; i++)
    {
        mas[i] = Math.Pow((i + 1), 3);
    }
    return string.Join(", ", mas);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число: ");
Console.WriteLine($"{number} -> {GetTableCubes(number)}");

