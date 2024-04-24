using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    public class Enumerable
    {

        //Input Длинная последовательность чисел.
        //Output (для одного числа ровно одна строка)
        //Если делится на 3, то "foo"
        //Если делится на 5, то "bar"
        //Если делится на 15, то "foobar"
        //В противном случае само число, преобразованное в строку

        //ВНИМАНИЕ: В задаче нет никаких подстав и попыток обмануть, напишите решение в лоб
        //Если вы решаете эту задачу не в IDE — можете использовать однобуквенные имена переменных.
        //Опечатки, ошибки в синтакисе и вообще все, что подскажет IDE — значения не имеют.

        public static IEnumerable<string> ConvertToFooBar(IEnumerable<int> enumerable)
        {
            //if (enumerable == null)

            //    throw reference Exeption;



            //return enumerable.Where(x => x % 3 == 0).Select(x => "foo");
            //return enumerable.Where(x => x % 5 == 0).Select(x => "bar");
            //return enumerable.Where(x => x % 15 == 0);
            //return enumerable.Where(x => x % 3 != 0 && x=>x % 5 != 0 $$ x => x % 15 != 0).Select(x => x.ToString());




            foreach (int a in enumerable)
            {
                if (a % 3 == 0) yield return "foo";
                if (a % 5 == 0) yield return "bar";
                if (a % 15 == 0) yield return "foobar";
                else yield return a.ToString();
            }
        }

    }

    //static void Main()
    //{
    //    var x = new[] { 3, 7, 15, 5 };


    //    //IEnumerable<string> x = null;


    //    foreach (var s in ConvertToFooBar(x))
    //    {
    //        Console.WriteLine(s);
    //        // "foo"
    //        // "7"
    //        // "foobar"
    //        // "bar"
    //    }
    //}

}

