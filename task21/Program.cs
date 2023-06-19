// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int XA = Promt("введите координату Xa: ");
int YA = Promt("введите координату Ya: ");
int XC = Promt("введите координату Xc: ");
int XB = Promt("введите координату Xb: ");
int YB = Promt("введите координату Yb: ");
int YC = Promt("введите координату Yc: ");
int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double AB = Math.Sqrt((XB-XA)*(XB-XA)+(YB-YA)*(YB-YA)+(YC-XC)*(YC-XC));
 Console.WriteLine(AB);