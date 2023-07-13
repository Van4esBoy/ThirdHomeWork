// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int num,r,sum=0,t;

// Console.WriteLine("Введите пятизначное число: ");
// num = Convert.ToInt32(Console.ReadLine());

// if(num>9999 && num<100000)
// {
// for(t=num;num!=0;num=num/10)
// {
// r=num % 10;
// sum=sum*10+r;
// }
// if(t==sum)
// Console.WriteLine($"{t} является палиндромом.");
// else
// Console.WriteLine($"{t} не является палиндромом.");
// } 
// else
// Console.WriteLine("Введите пятизначное число! ");



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputN(string message)
{
System.Console.WriteLine($"{message}> ");
int value;
if (int.TryParse(Console.ReadLine(), out value))
{
return value;
}
System.Console.WriteLine("Вы ввели не число");
Environment.Exit(1);
return 0;

}

int x1 = InputN ("Введите координату X точки A");
int y1 = InputN ("Введите координату Y точки A");
int z1 = InputN ("Введите координату Z точки A");
int x2 = InputN ("Введите координату X точки B");
int y2 = InputN ("Введите координату Y точки B");
int z2 = InputN ("Введите координату Z точки B");

double dis(int x1, int y1, int z1, int x2, int y2, int z2)
{
int deltax = x2 - x1;
int deltay = y2 - y1;
int deltaz = z2 - z1;
return Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
}
System.Console.WriteLine($"Растояние между точками A и B равно {dis(x1, y1, z1, x2, y2, z2):F2} ");