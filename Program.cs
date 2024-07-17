using System;





Firm f = new Firm();
Console.WriteLine(f.INN);  //1 /null
f.INN = 3;
Firm.ChangeINN(ref f); // изменяет переменную на 2
Console.WriteLine(f.INN); //2


Console.ReadKey();

public class Firm
{
    public int INN = 1; // при обьявлении класса поле инициализируется inn 1

    public static void ChangeINN(ref Firm firm)
    {
        firm.INN = 2;
        firm = new Firm();
    }

}








