using System;
int a = 10, b = 1;
TestClass.Compare(a, b);
string c = "hi", d = "bye";
TestClass.Compare(c, d);
double e = 10.2, f = 10.2;
TestClass.Compare(e, f);


public class TestClass
{
    public static bool Compare(string a, string b) => a == b;

    public static bool Compare(int a, int b) => a == b;

    public static bool Compare(double a, double b) => a == b;

    public static bool Compare<T>(T a, T b)
    {
        return a.Equals(b);
    }
}