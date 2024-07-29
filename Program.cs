using System;





//Firm f = new Firm();
//Console.WriteLine(f.INN);  //1 /null
//f.INN = 3; // полю присвоили 3
//Firm.ChangeINN(f); // изменяет этоже поле переменную на 2, если с реф то не изменит
//Console.WriteLine(f.INN); //2


//Console.ReadKey();

//public class Firm
//{
//    public int INN = 1; // при обьявлении класса поле инициализируется inn 1

//    public static void ChangeINN(Firm firm)  // если с ref то 1 передатим ссылку и меняем f
//    {
//        firm = new Firm(); // перезаписана локальная переменная создадим новый обьект перезапись ссылки, но мы уже успели поменять поэтому ссылка не потеряется
//        firm.INN = 2;
//    }

//}


//var a = new A { Value = 5 }; // короткая запись
A a = new A();
a.Value = 5;
Helper.Test(ref a);
Console.WriteLine(a.Value); // выведет 10 с ref 15

Console.ReadKey();

public class A
{
    public int Value { get; set; }
}


public static class Helper
{
    public static void Test(ref A a) //без реф перезаписали локальную переменную
    {
        a.Value = 10;

        a = new A { Value = 15 }; // новая 
    }
}



// класс бинарное дерево

public class TreeNode
{
    public int Value { get; set; }

    public TreeNode Left { get; set; }

    public TreeNode Right { get; set; }
}



