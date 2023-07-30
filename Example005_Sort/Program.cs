// Дано: 5 гирь с разным весом в случайном порядке.
// Найти: вес самой тяжелой гири.

int a = 8;
int b = 9;
int c = 1;
int d = 2;
int e = 13;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);
