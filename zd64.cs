string GetString(int usersNumber)
{

    if (usersNumber > 1) return usersNumber.ToString() + ", " + GetString(usersNumber - 1);
    else return usersNumber.ToString();
}


void Main()
{
    Console.Write("Введите число:\n>>> ");
    bool flag = int.TryParse(Console.ReadLine()!, out int number);
    if (flag) Console.WriteLine(GetString(number));
    else Console.WriteLine("Не удалось преобразовать введенный текст к числу, повторите попытку");
}

Main();