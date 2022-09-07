// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 1");
Console.Write("а=");
int a = int.Parse(Console.ReadLine());
Console.Write("b=");
int b = int.Parse(Console.ReadLine());
if(a > b) {
    Console.WriteLine("max=" + a);
} else if (b > a) {
    Console.WriteLine("max=" + b);
} else if (a == b) {
    Console.WriteLine("a=b, " + a);
}
