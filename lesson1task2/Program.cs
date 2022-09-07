Console.WriteLine("Задача 2");
String[] stringArray = Console.ReadLine().Split();
int a1 = int.Parse(stringArray[0]);
int b1 = int.Parse(stringArray[1]);
int c1 = int.Parse(stringArray[2]);
int max = a1;
if(b1 > max) {
    max = b1;
} 
if (c1 > max) {
    max = c1;
}
Console.WriteLine(max);