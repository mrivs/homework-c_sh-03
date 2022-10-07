/*/

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

/*/

int N = PrintAndGetValue("введите N");

string str = "";

if (N > 0)
{

    for (int i = 1; i <= N; i++)
    {

        if (i != N)
        {
            str = str + Math.Pow(i, 3) + ", ";
        }
        else
            str = str + Math.Pow(i, 3);
    }

    Console.WriteLine(str);
}
else Console.WriteLine("неверное число");




int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int v = int.Parse(Console.ReadLine());
    return v;
}