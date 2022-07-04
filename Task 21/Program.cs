// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double len(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    double result = 0;
    if (X1 == X2 && Y1 == Y2 && Z1 == Z2)
    {
        return result;
    }
    else 
    { 
        result = Math.Sqrt(Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1, 2) + Math.Pow(Z2-Z1, 2));
        return result;
    }
}



double A = len(3, 6, 8, 2, 1, -7);
Console.WriteLine(A);
double B = len(7, -5, 0, 1, -1, 9);
Console.WriteLine(B);
double C = len(7, -5, 0, 7, -5, 0);
Console.WriteLine(C);
