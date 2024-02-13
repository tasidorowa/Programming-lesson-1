// Одинаковые типы данных у операндов
int a1 = 5;
int a2 = 6;
int sum = a1 + a2;
Console.WriteLine(sum);

// Разные типы данных у операндов
long l1 = 6;
long sum2 = a1 + l1;
Console.WriteLine(sum2);

double d1 = 5.5;
double sum3 = d1 + l1;

int prod1 = a1 * a2;
long prod2 = l1 * a1;
double prod3 = a1 * d1;
Console.WriteLine(prod1);
Console.WriteLine(prod2);
Console.WriteLine(prod3);

int quo = a1 / a2;
Console.WriteLine(quo);

d1 = 6;
double quo2 = a1 / d1;
Console.WriteLine(quo2);