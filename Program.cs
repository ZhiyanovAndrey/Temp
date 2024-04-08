using System;


String s1 = "Hello World";
String s2 = "Hello World";

Console.WriteLine(s1==s2);
Console.ReadKey();

//assertThat(s1 == s2).isTrue();



// ввыводит 10, при добавлении ref 15

var a = new A { Value = 5 };
Helper.Test(a);
Console.WriteLine(a.Value);

Console.ReadKey();

public class A
{
    public int Value { get; set; }
}


public static class Helper
{
    public static void Test(A a)
    {
        a.Value = 10;

        var b = ReferenceEquals(a.Value, a);
        a = new A { Value = 15 };
    }
}