double m, n, a, b, x;
string input;

Console.WriteLine("Write n, m, a, b, x spliting them by space\n");
input = Console.ReadLine();

string[] data = input.Split(" ");


n = System.Convert.ToDouble(data[0]);
m = System.Convert.ToDouble(data[1]);
a = System.Convert.ToDouble(data[2]);
b = System.Convert.ToDouble(data[3]);
x = System.Convert.ToDouble(data[4]);

double z1, z2, y;

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine("Z1: " + z1 + "\nZ2: " + z2 + "\nY: " + y);
