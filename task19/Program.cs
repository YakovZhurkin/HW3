// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = Promt("Введите пятизначное число: ");
int Cop = number;
int rev = 0;
if (10000<=number && number<=100000)
{
while(number > 0)
{
    int ost = number % 10;
   rev = rev * 10 + ost;
    number = number / 10;
}
Console.WriteLine(rev);
    if (Cop == rev)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является полиндромом");
}
}
else {
    Console.WriteLine("Число НЕ пятизначное!");
}

int Promt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

