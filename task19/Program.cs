// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string IdentifyPolindrom(string polindrom)
{
    int size = polindrom.Length;
    string result = "";
    if (size != 5) result = "число не пятизначное!";
    else
    {
        int j = (polindrom.Length - 1);
        for (int i = 0; i < (size / 2); i++)
        {
            if (polindrom[i] == polindrom[j])
            {
                result = "да ";
                j = j -1;
            }
            else result = "нет";
            break;
        }
    }
    return result;
}

string GetInpoot(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string number = GetInpoot("Введите пятизначное число: ");
Console.WriteLine($"{number} -> {IdentifyPolindrom(number)}");
