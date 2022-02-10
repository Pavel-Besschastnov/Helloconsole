// Задача 22
// Найти расстояние между точками в пространстве 2D/3D

using static System.Console;
using static System.Math;

int X1 = new Random().Next(1, 100);
int X2 = new Random().Next(1, 100);
int Y1 = new Random().Next(1, 100);
int Y2 = new Random().Next(1, 100);
int Z1 = new Random().Next(1, 100);
int Z2 = new Random().Next(1, 100);
WriteLine($"{X1}  {X2}  {Y1}   {Y2}  {Z1}   {Z2}");
int ab = (X2 - X1)^2 + (Y2 -Y1)^2 + (Z2 -Z1)^2;
double AB =Sqrt(ab);
WriteLine(" Расстояние между двумя точками :");
WriteLine(AB);