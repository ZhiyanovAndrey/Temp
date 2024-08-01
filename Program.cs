using System;


// c ref 4 5
// без ref 4 2
// меняем местами  firm = new Firm(5); И firm.INN = 2; И ВЫВОД 4 3  // перезаписана локальная переменная создадим новый обьект перезапись ссылки,



Firm f = new Firm(4); // Ссылка1, вызов конструктора и инициализация полей
Console.WriteLine(f.INN);  //1, я сказал null, т.к. присваиваем пустой список
f.INN = 3; // полю присвоили 3
Firm.ChangeINN(f); // передаем тип со значением 3, изменяет его на 2 при выходе из метода,
                   // если с реф то не изменит
Console.WriteLine(f.INN); //2, при перемещении  firm.INN = 2; ниже выведет 3


Console.ReadKey();

public class Firm
{

    public int INN = 1; // при обьявлении класса поле инициализируется inn 1

    public Firm(int i) // конструктор для изменения значения по умолчанию
    {
        INN = i;     
    }

    public Firm() // перегружаем конструктор, что бы использовать значение по умолчанию public int INN = 1;
    {
            
    }
    // Ссылка2, создали локальную переменную firm
    public static void ChangeINN(Firm firm)  // передали 3 в метод, если с ref то 1 передатим ссылку и меняем f
    {
        firm = new Firm(5); // перезаписана локальная переменная создадим новый обьект перезапись ссылки,
        firm.INN = 2; // изменили 3 на 2
                           // но мы уже успели поменять поэтому ссылка не потеряется
    }

}



//A a = new A();
//a.Value = 5;
//// короткая запись: var a = new A { Value = 5 }; 
//Helper.Test(ref a);
//Console.WriteLine(a.Value); // выведет 10 с ref 15

//Console.ReadKey();

//public class A
//{
//    public int Value { get; set; }
//}


//public static class Helper
//{
//    public static void Test(ref A a) //без реф перезаписали локальную переменную
//    {
//        a.Value = 10;

//        a = new A { Value = 15 }; // новая ссылка
//    }
//}



// класс бинарное дерево

public class TreeNode
{
    public int Value { get; set; }

    public TreeNode Left { get; set; }

    public TreeNode Right { get; set; }
}



