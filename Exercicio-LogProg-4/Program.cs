using System;
int a = 10, b = 1;
TestClass<string>.Compare(a, b);
string c = "hi", d = "bye";
TestClass<string>.Compare(c, d);
double e = 10.2, f = 10.2;
TestClass<string>.Compare(e, f);
TestClass<string>.Compare(c, f);

public class TestClass<T> where T : IComparable<T>
{
    public static void Compare(string a, string b)
    {
        Console.WriteLine("String");
        if (a.CompareTo(b) > 0)
        {
            Console.WriteLine("Not equals");
        }
        else
        if (a.CompareTo(b) < 0)
        {
            Console.WriteLine("Not equals");
        }
        else
        {
            Console.WriteLine("Equals");
        }
    }
    public static void Compare(int a, int b)
    {
        Console.WriteLine("Int");
        if (a.CompareTo(b) > 0)
        {
            Console.WriteLine("Not equals");
        }
        else
        if (a.CompareTo(b) < 0)
        {
            Console.WriteLine("Not equals");
        }
        else
        {
            Console.WriteLine("Equals");
        }
    }

    public static void Compare(double a, double b)
    {
        Console.WriteLine("Double");
        if (a.CompareTo(b) > 0)
        {
            Console.WriteLine("Not equals");
        }
        else
        if (a.CompareTo(b) < 0)
        {
            Console.WriteLine("Not equals");
        }
        else
        {
            Console.WriteLine("Equals");
        }
    }

    public static void Compare(T a, T b)
    {
        Console.WriteLine("Generic");
        if (a.CompareTo(b) > 0)
        {
            Console.WriteLine("Not equals");
        }
        else
        if (a.CompareTo(b) < 0)
        {
            Console.WriteLine("Not equals");
        }
        else
        {
            Console.WriteLine("Equals");
        }
    }
}