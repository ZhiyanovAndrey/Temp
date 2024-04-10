using System;


//String s1 = "Hello World";
//String s2 = "Hello World";

//Console.WriteLine(s1==s2);
//Console.ReadKey();

//assertThat(s1 == s2).isTrue();



// ввыводит 10, при добавлении ref 15


//int num = 2;

//Multiply(num);

//Console.WriteLine(num);

//Console.ReadKey();


// static void Multiply(int num) // будет создана новая переменная (их называют локальными)
//{
//    num *= 2;
//}

//сделать пример со string


A a = new A { Value = 5 };  // создаем объект ссылочный
Helper.Test(a); // передаем ссылку на 5
Console.WriteLine(a.ToString());

Console.WriteLine();


Console.ReadKey();

static void AnonymousType()
{
    var v = new { Title = "Hello", Age = 24 };

    Console.WriteLine(v.ToString()); // "{ Title = Hello, Age = 24 }"
}

static void AnonymousTypeMutation()
{
    var apple = new { Item = "apples", Price = 1.35 };
    var onSale = apple with { Price = 0.79 };
    Console.WriteLine(apple); // "{ Item = "apples", Age = 24 }"
    Console.WriteLine(onSale); // "{ Item = "apples", Age = 24 }"
}





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