using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Temp;


    // Задача:
    // В классе прямоугольник используются 2 конструктора для создания.
    // 1-й конструктор принимает координаты начальной и конечной точки.
    // 2-й конструктор принимает координаты начальной точки и размер прямоугольника.
    // Проблема в том, что при чтении вызывающего кода сложно понять, по какому из двух алгоритмов создается прямоугольник
    // 2-я проблема - это то, что оба конструктора принимают одинаковое количество числовых аргументов. Пришлось сделать костыль (float вместо int), чтобы получить возможность реализовать оба конструктора
    // Как можно исправить ситуацию и сделать вызывающий код более читаемым?

    
    var rect1 = new Rectangle(40, 50);
    var rect2 = new Rectangle(10, 10);
rect1.WriteAB();
rect2.WriteAB();
Console.WriteLine ($"Квадрат {rect1.Perimeter()}");


//   public class Rectangle
//{
//public int X { get; }
//public int Y { get; }
//public int Width { get; }
//public int Height { get; }
//public Rectangle(int x1, int y1, int x2, int y2)
//    {
//    X = x1;
//    Y = y1;
//    Width = x2 - x1;
//    Height = y2 - y1;
//}
//public Rectangle(int x, int y, float width, float height)
//    {
//    X = x;
//    Y = y;
//    Width = (int)width;
//    Height = (int)height;
//}
//}
Console.ReadKey();

class Rectangle
{
    //поля
    private int a, b;

    //конструктор
    public Rectangle(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    //Метод для вывода длин сторон прямоугольника на экран
    public void WriteAB()
    {
        Console.WriteLine("Длина a={0}", a);
        Console.WriteLine("Длина b={0}", b);
    }

    //Метод возвращает периметр прямоугольника
    public int Perimeter()
    {
        return 2 * a + 2 * b;
    }

    //Метод возвращает площадь прямоугольника
    public int Area()
    {
        return a * b;
    }

    //Свойства для чтения и записи поля a
    public int A
    {
        get { return a; }
        set { a = value; }
    }

    //Свойства для чтения и записи поля b
    public int B
    {
        get { return b; }
        set { b = value; }
    }

    //Свойство для чтения - является ли данный прямоугольник квадратом 
    public bool IsSquare
    {
        get { return a == b; }
    }

    //Индексатор
    public int this[int index]
    {
        get
        {
            if (index == 0)
                return a;
            if (index == 1)
                return b;

            Console.WriteLine("Неверный индекс {0}", index);
            return -1;
        }

        set
        {
            if (index == 0)
                a = value;
            if (index == 1)
                b = value;
            if (index != 0 && index != 1)
                Console.WriteLine("Неверный индекс {0}", index);
        }
    }

    //Перегрузка оператора ++
    public static Rectangle operator ++(Rectangle r)
    {
        r.A++;
        r.B++;
        return r;
    }

    //Перегрузка оператора --
    public static Rectangle operator --(Rectangle r)
    {
        r.A--;
        r.B--;
        return r;
    }

    //Перегрузка оператора false
    public static bool operator false(Rectangle r)
    {
        if (!r.IsSquare)
            return false;
        return true;
    }

    //Перегрузка оператора true
    public static bool operator true(Rectangle r)
    {
        if (r.IsSquare)
            return true;
        return false;
    }
    //Перегрузка оператора умножения на скаляр (справа)
    public static Rectangle operator *(Rectangle r, int v)
    {
        r.A *= v;
        r.B *= v;
        return r;
    }

    //Перегрузка оператора умножения на скаляр (слева)
    public static Rectangle operator *(int v, Rectangle r)
    {
        r.A *= v;
        r.B *= v;
        return r;
    }

    //Перегрузка преобразования Rectange в string
    public static implicit operator string(Rectangle r)
    {
        //результирующая строка состоит из значений a и b через пробел
        return r.A.ToString() + " " + r.B.ToString();
    }

    //Перегрузка преобразования string в Rectange
    public static implicit operator Rectangle(string s)
    {
        //выделяем числа из строки (они в строке даны через пробел)
        string[] w = s.Split(' ');
        //возвращаем новый Rectangle
        return new Rectangle(Convert.ToInt32(w[0]), Convert.ToInt32(w[1]));
    }
}




