/*/Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

/*/



int [] A={PrintAndGetValue("введите x1"),PrintAndGetValue("введите y1"),PrintAndGetValue("введите z1")};
int [] B={PrintAndGetValue("введите x2"),PrintAndGetValue("введите y2"),PrintAndGetValue("введите z2")};


string result = string.Format("{0:f2}", GetDistanse(A,B));
Console.WriteLine(result);


double GetDistanse(int []A, int []B)
{
    double res = Math.Sqrt(Math.Pow((A[0] - B[0]), 2) + Math.Pow((A[1] - B[1]), 2)+ Math.Pow((A[2] - B[2]), 2));
    return res;
}

int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int v = int.Parse(Console.ReadLine());
    return v;
}