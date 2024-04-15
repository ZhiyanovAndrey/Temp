using System;



var x = new[] { 3, 7, 15, 5 };


//IEnumerable<string> x = null;


foreach (var s in ConvertToFooBar(x))
{
    Console.WriteLine(s);
    // "foo"
    // "7"
    // "foobar"
    // "bar"
}

static IEnumerable<string> ConvertToFooBar(IEnumerable<int> enumerable)
{
    //if (enumerable == null)

    //    throw reference Exeption;



    return enumerable.Where(x => x % 3 == 0).Select(x => "foo");
    //return enumerable.Where(x => x % 5 == 0).Select(x => "bar");
    //return enumerable.Where(x => x % 15 == 0);
    //return enumerable.Where(x => x % 3 != 0 && x=>x % 5 != 0 $$ x => x % 15 != 0).Select(x => x.ToString());




    //Foreach(int a in enumerable){
    //    if (enumerable % 3 == 0) yield return "foo";
    //    if (enumerable % 5 == 0) yield return "bar";
    //    if (enumerable % 15 == 0) yield return "foobar";
    //    else yield return a.ToString();
    //}
}

//String s1 = "Hello World";
//String s2 = "Hello World";

//Console.WriteLine(s1==s2);
//Console.ReadKey();





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




// ввыводит 10, при добавлении ref выводит 15

A a = new A { Value = 5 };  // создаем объект ссылочный, что за запись 1 
Helper.Test(a); // копируем ссылку на a
Console.WriteLine(a.Value); // 10
Console.WriteLine(a.ToString()); // A
Console.WriteLine(a.GetType()); // A ????

Console.WriteLine();


Console.ReadKey();



public class A
{
    public int Value { get; set; }
}


public static class Helper
{
    public static void Test(A a) // 2 ссылка
    {
        a.Value = 10; // изменяем локальную переменную a и глобальная переменная тоже меняется 2

        a = new A { Value = 15 }; // изменяет только локальную переменную другая ссылка
    }
}


//string num = "2";

//Multiply(ref num); // не изменяет num без ref

//Console.WriteLine($"num {num}");

//static void Multiply(ref string i) // будет создана новая переменная (их называют локальными)
//{
//    Console.WriteLine($"Multiply {i + i}"); // выведет 4 не изменит i
//    i += i; // изменит локальную переменную
//}


//static void AnonymousType()
//{
//    var v = new { Title = "Hello", Age = 24 };

//    Console.WriteLine(v.ToString()); // "{ Title = Hello, Age = 24 }"
//}

//static void AnonymousTypeMutation()
//{
//    var apple = new { Item = "apples", Price = 1.35 };
//    var onSale = apple with { Price = 0.79 };
//    Console.WriteLine(apple); // "{ Item = "apples", Age = 24 }"
//    Console.WriteLine(onSale); // "{ Item = "apples", Age = 24 }"
//}





