using System;
var a = System.Console.ReadLine();
var b = System.Console.ReadLine();
TestClass<string>.Compare(a, b);

public class TestClass<T> where T : IComparable<T>
{
    public static void Compare(string a, string b)
    {
        Console.WriteLine("String");
        Console.WriteLine(string.Compare(a,b));
    }
    public static void Compare(int a, int b)
    {
        Console.WriteLine("Int");
        Console.WriteLine(a.CompareTo(b));
    }

    public static void Compare(double a, double b)
    {
        Console.WriteLine("Double");
        Console.WriteLine(a.CompareTo(b));
    }

    public static void Compare(T a, T b)
    {
        Console.WriteLine("Generic");
        if (a.CompareTo(b) > 0)
        {
            // Actions, if obj>other
            // ...
            Console.WriteLine("False");
        }
        else
    if (a.CompareTo(b) < 0)
        {
            // Actions, if obj<other
            // ...
            Console.WriteLine("False");
        }
        else
        {
            // Actions, if obj==other
            // ...
            Console.WriteLine("True");
        }
    }
}