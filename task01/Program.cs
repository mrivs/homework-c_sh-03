
/*/
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
/*/

int A = PrintAndGetValue("введите пятизначное число");

if (LengthInt(A) == 5)
{
    if (IsPalindrome(A))  Console.WriteLine("да"); 
    else Console.WriteLine("нет");
}
else Console.WriteLine("число не пятизначное =/");



bool IsPalindrome(int A) // определяет является ли число палиндромом
{
    bool bres = true;
    for (int i = 1; i < LengthInt(A) / 2; i++)
    {
        if (NumberR(A, i) != NumberR(A, LengthInt(A) - i + 1))
        {
            bres = false;
        }
    }
    return bres;
}

int NumberR(int A, int n) // находит n-ю цифру числа А (справа налево)
{

    int r = (int)(A / (Math.Pow(10, n - 1)) % 10);
    return r;
}


int LengthInt(int A) // находит длинну числа А 
{
    int l = 1;
    A = Math.Abs(A);

    while (A > 9)
    {
        A = A / 10;
        l++;
    }
    return l;
}

int PrintAndGetValue(string message) // текст и ввод целого числа 
{
    Console.WriteLine(message);
    int v = int.Parse(Console.ReadLine());
    return v;
}