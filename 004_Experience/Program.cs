double a = new Random().Next (0,101);
Console.WriteLine (a);
double b = new Random().Next (0,101);
Console.WriteLine (b);
double c= new Random ().Next(0,101);
Console.WriteLine (c);
double d = new Random ().Next(0,101);
Console.WriteLine (d);

double sred = (a+b+c+d)/4;

Console.Write ("Среднее арифетическое = ");
Console.WriteLine (sred);

double max = a;

if (b>max) {max=b;}
if (c>max) {max=c;}
if (d>max) {max=d;}

Console.Write("Максимальное число= ");
Console.WriteLine(max);

double min = a;

if (b<min) {min=b;}
if (c<min) {min=c;}
if (d<min) {min=d;}

Console.Write("Минимальное число= ");
Console.WriteLine(min);
