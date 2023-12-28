using System.Net;
using System.Text;



Console.WriteLine($"Сумма = {CamelCase.BreakCamelCase("camelCasingTestPrint")}");
Console.WriteLine();
Console.WriteLine($"Сумма = {Calc.Sum(2, 4)}");
Console.WriteLine($"Произведение = {Calc.multiply(2, 4)}");









Console.WriteLine($"Сумма = {IPValidation.is_valid_IP1("10.10.10.10")}");



Console.ReadKey();



public class IPValidation
{

    // возврат IP в нормальном виде
    public static string is_valid_IP1(string Address)
    {
        string ip = string.Empty;
        string pattern = @"dd?d?.dd?d?.dd?d?.dd?d?";
        System.Text.RegularExpressions.Regex regex =
        new System.Text.RegularExpressions.Regex(pattern);
        System.Text.RegularExpressions.Match match = regex.Match(Address);
        while (match.Success)
        {
            ip = match.Value;
            match = match.NextMatch();
        }
        return ip;
    }
    public static bool is_valid_IP(string ipAddres)
    {
        //Инициализируем новый экземпляр класса System.Text.RegularExpressions.Regex
        //для указанного регулярного выражения.
        System.Text.RegularExpressions.Regex IpMatch = new System.Text.RegularExpressions.Regex(@"b(?:d{1,3}.){3}d{1,3}b");
        //Выполняем проверку обнаружено ли в указанной входной строке
        //соответствие регулярному выражению, заданному в
        //конструкторе System.Text.RegularExpressions.Regex.
        //если да то возвращаем true, если нет то false
        return IpMatch.IsMatch(ipAddres);
    }
}


// класс для unittests
public class Calc
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static long multiply(int a, int b)
    {
        return a * b;
    }
}




//// разбить предложение по словам Console.WriteLine($"Сумма = {BreakCamelCase("camelCasingTestPrint")}");
//static string BreakCamelCase(string str)
//{
//    System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

//    string result = string.Empty;
//    int startindex = 0;

//    for (int i = 0; i < str.Length; i++)
//    {

//        if (str[i] == str.ToUpper()[i])
//        {


//            //result= str.Insert(i, " ");
//            stringBuilder.Append(str, startindex, i-startindex);
//            stringBuilder.Append(' ');
//            startindex = i;

//        }


//    }

//    stringBuilder=stringBuilder.Append(str,startindex,str.Length-startindex);


//    return stringBuilder.ToString();
//}


//namespace Solution
//{
//    using NUnit.Framework;
//    using System;
//    using System.Collections.Generic;

//    [TestFixture]
//    public class Sample_Tests
//    {
//        private static IEnumerable<TestCaseData> testCases
//        {
//            get
//            {
//                yield return new TestCaseData("camelCasing").Returns("camel Casing");
//                yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
//            }
//        }

//        [Test, TestCaseSource("testCases")]
//        public string Test(string str) => Kata.BreakCamelCase(str);
//    }
//}






// складываем цифры кратные 3 или 5 
//static int Solution(int value) => Enumerable.Range(0, value).Where(x => x % 3 == 0 || x % 5 == 0).Sum();          //Sum(i => i % 3 == 0 || i % 5 == 0 ? i : 0); 
//static int Solution(int value) => value < 3 ? 0 : Enumerable.Range(3, value - 3).Where(x => x % 3 == 0 || x % 5 == 0).Sum();


//static int Solution(int value)
//{
//    List<int> list = new List<int>();
//    //int[] arr = new int[value];
//    bool flag = false;
//    int sum = 0;
//    if (value < 0) sum = 0;

//    for (int i = 1; i < value; i++)
//    {

//        if (i % 3 == 0) flag = true;
//        else if (i % 5 == 0) flag = true; // когда есть 3 на 5 уже не идет
//        if (flag) list.Add(i);
//        flag = false;

//    }

//    foreach (var item in list)
//    {
//        sum += item;
//    }
//    return sum;
//}


//    public class Test
//{
//    [Test]
//    public void SampleTests()
//    {
//        Assertion(expected: 23, input: 10);
//        Assertion(expected: 78, input: 20);
//        Assertion(expected: 9168, input: 200);
//        Assertion(expected: 0, input: 0);
//    }

//    private static void Assertion(int expected, int input) =>
//      Assert.AreEqual(
//        expected,
//        Kata.Solution(input),
//        $"Value: {input}"
//      );








//// суммирует только 2 числа в массиве
//TwoSum(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray();


//static int[] TwoSum(int[] numbers, int target)
//{
//    List<int> result = new List<int>();
//    for (int i = 0; i < numbers.Length - 1; i++)
//    {
//        for (int j = i + 1; j < numbers.Length; j++)
//        {
//            int a = numbers[i] + numbers[j];
//            if (a == target)
//            {
//                result.Add(numbers[i]);
//                result.Add(numbers[j]);

//            }

//        }

//    }


//    return result.ToArray();
//}

public class CamelCase
{
    // разбить предложение по словам
    internal static string BreakCamelCase(string str)
    {
        System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

        string result = string.Empty;
        int startindex = 0;

        for (int i = 0; i < str.Length; i++)
        {

            if (str[i] == str.ToUpper()[i])
            {


                //result= str.Insert(i, " ");
                stringBuilder.Append(str, startindex, i - startindex);
                stringBuilder.Append(' ');
                startindex = i;

            }


        }

        stringBuilder = stringBuilder.Append(str, startindex, str.Length - startindex);


        return stringBuilder.ToString();
    }
}






