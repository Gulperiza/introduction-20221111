// 14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
System.Console.WriteLine("Введите число а:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
if (b % a==0) System.Console.WriteLine($"{a} кратно числу {b}");
if (b % a!=0) System.Console.WriteLine($"{a} не кратно числу {b}");