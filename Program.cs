using System;





  Firm f = new Firm();
        Console.WriteLine(f.INN);  //null
        f.INN = 3;
        ChangeINN(f);
        Console.WriteLine(f.INN); //3



public class Firm
{
    public int INN = 1; // при обьявлении класса поле инициализируется inn 1

    public static void ChangeINN(Firm firm)
    {
        firm.INN = 2;
        firm = new Firm();
    }

}



Console.ReadKey();





