void GetThirdPow(int number)
{
    int step = 1;
    double? thirdPow = null;
    string stringResult = "";

    if (number < 1)
    {
        step = -1;
    }

    for (int i = 1; i != (number + step); i += step)
    {
        thirdPow = Math.Pow(i, 3);

        stringResult = $"{thirdPow}";

        if (i != number)
        {
            stringResult = stringResult + ", ";
        }

        Console.Write(stringResult);
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

GetThirdPow(number);