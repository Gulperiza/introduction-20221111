// 7. Выяснить является ли число чётным.
System.Console.WriteLine("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());  
if (n % 2 == 0) System.Console.WriteLine($"Данное число четное");
if (n % 2 != 0) System.Console.WriteLine($"Данное число не четное");