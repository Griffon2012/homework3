bool IsCheckNUmber(int number, out string? textError)
{
    textError = null;
    if (number < 0)
    {
        textError = "Число отрицательное";
        return false;
    }
    if (number > 99999 || number < 10000)
    {
        textError = "Число не пятизначное";
        return false;
    }

    return true;
}

bool IsPalindrom(int originalNumber)
{
    int number = originalNumber;
    int reversNumber = 0;

    while (number > 0)
    {
        reversNumber = (reversNumber * 10) + (number % 10);
        number = number / 10;
    }

    return originalNumber == reversNumber;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (IsCheckNUmber(number, out string? textError))
{
    if (IsPalindrom(number))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine(textError);
}
