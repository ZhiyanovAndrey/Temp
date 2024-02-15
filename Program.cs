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

    
    var rect1 = new Rectangle(10, 10, 40, 50);
    var rect2 = new Rectangle(10, 10, 30f, 40f);



   public class Rectangle
{
public int X { get; }
public int Y { get; }
public int Width { get; }
public int Height { get; }
public Rectangle(int x1, int y1, int x2, int y2)
    {
    X = x1;
    Y = y1;
    Width = x2 - x1;
    Height = y2 - y1;
}
public Rectangle(int x, int y, float width, float height)
    {
    X = x;
    Y = y;
    Width = (int)width;
    Height = (int)height;
}
}






