int GetSumOfIntegersInRange(int lowerBound, int upperBound)
{
    if (lowerBound != upperBound) return lowerBound + GetSumOfIntegersInRange(lowerBound + 1, upperBound - 1) + upperBound;
    else return lowerBound;
}

void Main()
{
    bool flag;
    Console.Write("Введите нижнюю границу диапазона суммирования:\n>>> ");
    flag = int.TryParse(Console.ReadLine()!, out int lBound);
    if (!flag)
    {
        Console.WriteLine("Не удалось преобразовать введенный текст к числу, повторите попытку");
        return;
    }
    Console.Write("Введите верхнюю границу диапазона суммирования:\n>>> ");
    flag = int.TryParse(Console.ReadLine()!, out int uBound);
    if (!flag)
    {
        Console.WriteLine("Не удалось преобразовать введенный текст к числу, повторите попытку");
        return;
    }
    int sumNumbers = GetSumOfIntegersInRange(lBound, uBound);
    Console.WriteLine($"Сумма чисел в диапазоне [{lBound}, {uBound}] = {sumNumbers}");
}

Main();