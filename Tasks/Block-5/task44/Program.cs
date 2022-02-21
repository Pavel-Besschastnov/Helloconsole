// 44 задача
// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double k1= new Random().Next(1,20);
double k2= new Random().Next(1,20);
double b1= new Random().Next(1,20);
double b2= new Random().Next(1,20);
Console.WriteLine($"k1 = {k1} k2 = {k2} b1 = {b1} b2 = {b2}");
double x;
double y;
x = (b1 - b2)/ (k2- k1);
y = k2*x+ b2;
Console.WriteLine( "При таких координатах точка пересечения будет с этими координатами");
Console.WriteLine($"x = {x} y = {y}");