// See https://aka.ms/new-console-template for more information
using System.Transactions;
/*
//task 1
Console.WriteLine("Hello, World!");

for(int i=1;i<101;i++){
    if (i%3 == 0 && i%5==0){
        Console.WriteLine("fizzbuzz");
    } else if (i%3==0){
        Console.WriteLine("fizz");
    }else if (i%3 ==0){
        Console.WriteLine("buzz");
    }else{
        Console.WriteLine(i);
    }
}
*/

byte a = 0;
byte b = 0;
string input = Console.ReadLine();
string input1 = Console.ReadLine();
Byte.TryParse(input, out a);
Byte.TryParse(input1, out b);
if ((a<0 || a > 255)||(b<0 || b>255)){
    Console.WriteLine("invalid value for byte");
}else
{
Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
try{
    checked {
        byte result = Convert.ToByte(a/b);
        Console.WriteLine($"Result = {result}");
    }
}catch (DivideByZeroException){
    Console.WriteLine("cannot divide by 0");
}
catch(OverflowException){
    Console.WriteLine("byte overflow");
}
}