// 4. По заданному с клавиатуры номеру дня недели вывести его название
System.Console.WriteLine("Введите число:");
double a=Convert.ToDouble(Console.ReadLine());
if(a==1) System.Console.WriteLine($"Сегодня ПОНЕДЕЛЬНИК");
if(a==2) System.Console.WriteLine($"Сегодня ВТОРНИК");
if(a==3) System.Console.WriteLine($"Сегодня СРЕДА");
if(a==4) System.Console.WriteLine($"Сегодня ЧЕТВЕРГ");
if(a==5) System.Console.WriteLine($"Сегодня ПЯТНИЦА");
if(a==6) System.Console.WriteLine($"Сегодня СУББОТА");
if(a==7) System.Console.WriteLine($"Ураа, Сегодня ВОСКРЕСЕНЬЕ");