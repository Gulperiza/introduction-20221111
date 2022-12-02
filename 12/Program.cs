// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
System.Console.WriteLine("Введите число от 10 до 99");
int N=Convert.ToInt32(Console.ReadLine());
if (N%10>N/10) System.Console.WriteLine($"{N%10} является максимальной цифрой числа {N}");
if (N/10>N%10) System.Console.WriteLine($"{N/10} является максимальной цифрой числа {N}");
