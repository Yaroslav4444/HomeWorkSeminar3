/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
int getNumberTest(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое число вы ввели {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}

int getSize(int num)
{
    string Size = Convert.ToString(Math.Abs(num));
    int size = Size.Length;
    return size;
}

int getPalindromTest(int num, int size)
{
    int i = 0;
    int Newnum = Math.Abs(num);
    double temp = 0;
    while (i <= size)
    {
        double FirstSign = Convert.ToInt32(Newnum / Math.Pow(10, size - 1));
        int LastSign = Newnum % 10;
        Newnum /= 10;
        temp = Newnum % Math.Pow(10, size - 2);
        Newnum = Convert.ToInt32(temp);

        if (FirstSign == LastSign)
        {
            i++;
            size -= 2;
        }
        else
        {
            break;
        }
    }
    return i;
}

int num = getNumberTest("Введите целое число :");
int size = getSize(num);
double answer = getPalindromTest(num, size);

if (answer == 0)
{
    Console.WriteLine($"Число {num} не палиндром");
}
else
{
    Console.WriteLine($"Число {num} палиндром");
}