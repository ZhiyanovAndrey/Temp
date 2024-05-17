using System;



var x = new[] { 7, 3, 15, 5 };


//IEnumerable<string> x = null;


foreach (var s in ConvertToFooBar(x))
{
    Console.WriteLine(s);
    // должен вывести
    // "foo"
    // "7" 
    // "foobar"
    // "bar"
}

static IEnumerable<string> ConvertToFooBar(IEnumerable<int> enumerable)
{
    //почему не идет 

    //foreach (int a in enumerable)
    //{

    //    if (a % 3 == 0) return enumerable.Select(x => "foo"); // возвращает коллекцию из 4 foo и дальше не идет 
    //    if (a % 5 == 0) return enumerable.Select(x => "bar");
    //    if (a % 15 == 0) return enumerable.Select(x => "foobar");

    //}

    //return enumerable.Select(x => x.ToString());

    foreach (int a in enumerable)
    {
        if (a % 3 == 0) yield return "foo"; // 15 тоже делится на 3, надо сделать если 15 то пропускаем
        if (a % 5 == 0) yield return "bar";
        if (a % 15 == 0) yield return "foobar";  
        else yield return a.ToString();
    }
}







Console.ReadKey();





