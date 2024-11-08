// See https://aka.ms/new-console-template for more information
double a, b, c, d;
string input;
input = Console.ReadLine();

string[] data = input.Split(" ");


a = System.Convert.ToDouble(data[0]);
b = System.Convert.ToDouble(data[1]);
c = System.Convert.ToDouble(data[2]);
d = System.Convert.ToDouble(data[3]);

double x, y, z, r;

x = (a + 2 * b + -c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
y = (5 * (a+b) * (c - d)) / ((1.0 / 2.0) * c) + Math.Pow(d,2) * (Math.Pow(a,2) - Math.Pow(b,2)) / (b - a);
z = (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a - 3 * b);
r = ((1.0 / 2.0) * a + (3.0 / 4.0) * b - (7.0 / 5.0)) / (3 * c + 1) + 1 / (a - c);

Console.WriteLine("X: " + x + "\nY: " + y + "\nZ: " + z + "\nR: " + r);
