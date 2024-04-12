using System;



//String s1 = "Hello World";
//String s2 = "Hello World";

//Console.WriteLine(s1==s2);
//Console.ReadKey();

//assertThat(s1 == s2).isTrue();



// ввыводит 10, при добавлении ref выводит 15


//string num = "2";

//Multiply(ref num); // не изменяет num без ref

//Console.WriteLine($"num {num}");


int i = 123;
object o = i;  // implicit boxing

try
{
    int j = (short)o;  // attempt to unbox

    System.Console.WriteLine("Unboxing OK.");
}
catch (Exception e)
{
    System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
}

//// приммер 1
int i1 = 1;
object obj = i1;
++i1;
Console.WriteLine("i = {0}", i1); // 2
Console.WriteLine("o = {0}", obj); // 1

int i2 = 123;

// Boxing copies the value of i into object o.
object o2 = i2;

// Change the value of i.
i2 = 456;

// The change in i doesn't affect the value stored in o.
System.Console.WriteLine("i = {0}", i2); // 456
System.Console.WriteLine("o = {0}", o2); // 123





A a = new A { Value = 5 };  // создаем объект ссылочный, что в фигурных
Helper.Test(a); // передаем ссылку на 5
Console.WriteLine(a.Value); // 10
Console.WriteLine(a.ToString()); // A
Console.WriteLine(a.GetType()); // A ????

Console.WriteLine();


Console.ReadKey();


static void Multiply(ref string i) // будет создана новая переменная (их называют локальными)
{
    Console.WriteLine($"Multiply {i + i}"); // выведет 4 не изменит i
    i += i; // изменит локальную переменную
}


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