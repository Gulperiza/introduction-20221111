// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.
System.Console.WriteLine("Введите число а:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
if(a>b) System.Console.WriteLine($"{a} является максимальным числом");
if(b>a) System.Console.WriteLine($"{b} является максимальным числом");
