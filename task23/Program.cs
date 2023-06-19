// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = Promt("Введите число: ");
findCube(number);

int Promt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void findCube( int Number)
{
int i = 1;
while (i<=Number)
{
   Console.Write(i*i*i + " ");
   i++;
}
}