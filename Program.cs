using System;





Firm f = new Firm();
Console.WriteLine(f.INN);  //1 /null
f.INN = 3;
Firm.ChangeINN(f); // изменяет переменную на 2, если с реф то не изменит
Console.WriteLine(f.INN); //2


Console.ReadKey();

public class Firm
{
    public int INN = 1; // при обьявлении класса поле инициализируется inn 1

    public static void ChangeINN(Firm firm)  // если с ref то 1
    {
        firm.INN = 2;
        firm = new Firm();
    }

}


//var a = new A { Value = 5 };
//Helper.Test(ref a);
//Console.WriteLine(a.Value); // выведет 10 с ref 15

//Console.ReadKey();

//public class A
//{
//    public int Value { get; set; }
//}


//public static class Helper
//{
//    public static void Test(ref A a)
//    {
//        a.Value = 10;

//        a = new A { Value = 15 };
//    }
//}








