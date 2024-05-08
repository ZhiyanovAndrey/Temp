using System;

var s1 = new List<string>() { "A" };
var s2 = new List<string>() { "A" };
var s4 = new List<string>() { "Б" };
var s3 = s1;

Console.WriteLine(s1 == s2); //false
Console.WriteLine(s1 == s3); //true
Console.WriteLine(object.ReferenceEquals(s1,s2)); //false

Console.ReadKey();




var x = new[] { 7, 3, 15, 5 };


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
    //почему не идет 
  
    foreach (int a in enumerable)
    {

        if (a % 3 == 0) return enumerable.Select(x => "foo"); // возвращает коллекцию из 4 foo и дальше не идет 
        if (a % 5 == 0) return enumerable.Select(x => "bar");
        if (a % 15 == 0) return enumerable.Select(x => "foobar");
       
    }

    return enumerable.Select(x => x.ToString());

    //foreach (int a in enumerable)
    //{
    //    if (a % 3 == 0) yield return "foo";
    //    if (a % 5 == 0) yield return "bar";
    //    if (a % 15 == 0) yield return "foobar";
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

A a = new A { Value = 5 };  // создаем объект ссылочный
Helper.Test(ref a); // остается 1-й ссылкой при возврате из метода, при добавлении ref a становится ссылкой 2
// ref когда значение изменится в методе ссылка остается прежней но ссылается на новое значение
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
    public static void Test(ref A a) // метод вносит изменения в текущую ссылку, c ref заменяет на 2-ю ссылку
    {
        a.Value = 10; // 1-я ссылка изменяем локальную переменную a и глобальная переменная тоже меняется 2

        a = new A { Value = 15 }; // создаем еще один объект с тем же именем, 2-я ссылка изменяет только локальную переменную
        Console.WriteLine(ReferenceEquals(a, a)); //false
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





