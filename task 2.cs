Console.WriteLine ("введите два числа");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
 if (a==b)
    Console.WriteLine ($"a = {a}; b = {b} -> a=b");
else {

 if (a > b)
    Console.WriteLine ($"a = {a}; b = {b} -> max = {a}");
else 
    Console.WriteLine ($"a = {a}; b = {b} -> max = {b}");
}