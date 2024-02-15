using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Temp;




// Задача: убрать дублирование кода в классах

class HydropressOperator
{
    public string Login;
    public string Fio;
    public Func<string, string, bool> CheckRightStrategy;
    public bool IsRightFor(string resource)
    {
        return CheckRightStrategy(Login, resource);
    }
}
class InspectorOTK
{
    public string Login;
    public string Fio;
    public Func<string, string, bool> CheckRightStrategy;
    public GuidSignId;
      public bool IsRightFor(string resource)
    {
        return CheckRightStrategy(Login, resource);
    }
}
// Задача: убрать дублирование кода в классах

class Rectangle : AClassWithLogger
{
    private Size size;
    public double CalculateArea()
    {
        try
        {
            double result = size.Width * size.Height;
            LogCalculationSucces();
            return result;
        }
        catch (Exception ex)
        {
            LogCalculationError(ex);
            throw;
        }
    }
}
class Circle : AClassWithLogger
{
    private int radius;
    public double CalculateArea()
    {
        try
        {
            double result = 2 * Math.PI * radius;
            LogCalculationSucces();
            return result;
        }
        catch (Exception ex)
        {
            LogCalculationError(ex);
            throw;
        }
    }
}

#region otherCode
abstract class AClassWithLogger
{
    protected void LogCalculationSucces()
    {
        throw new NotImplementedException();
    }
    protected void LogCalculationError(Exception ex)
    {
        thrownewNotImplementedException();
    }
}
# endregionotherCode
// Задача: убрать дублирование кода в методах подсчета

class Rectangle
{
    public int CalculatePerimeter()
    {
        try
        {
            Size size = GetCurrentSize();
            int result = size.Width + size.Height;
            LogCalculationSucces();
            return result;
        }
        catch (Exception ex)
        {
            LogCalculationError(ex);
            throw;
        }
    }
    public int CalculateArea()
    {
        try
        {
            Size size = GetCurrentSize();
            int result = size.Width * size.Height;
            LogCalculationSucces();
            return result;
        }
        catch (Exception ex)
        {
            LogCalculationError(ex);
            throw;
        }
    }

    #region otherCode
    private Size GetCurrentSize()
    {
        throw new NotImplementedException();
    }
    private void LogCalculationSucces()
    {
        throw new NotImplementedException();
    }
    private void LogCalculationError(Exception ex)
    {
        throw new NotImplementedException();
    }
# endregionotherCode
}

/* Задача:
  * Упростить код.
  * В коде представлен метод, реализующий сценарий по формированию 
  * и выводу отчета пользователю.
  * Для каждого действия в методе реализовано логирование.
  * При этом, реализовано 2 логера. Один пишет в БД, другой в файл. 
  * Сами логгеры создаются где то выше (в вызывающем коде). 
  * Там же принимается решение, какой логгер следует использовать в данный момент. 
  * В таком виде код страдает от постояного повторения условия по выбору логгера. 
  * На этом фоне сложно прочитать бизнес-логику.
  * Можно ли как-то оптимизировать этот код?
  * Можно ли вообще отделить логирование от бизнес логики, сделав код максимально чистым?
* */

partial class ReportForm
{
    public void buttonShowReportClick(DbLoggerdbLogger, FileLoggerfileLogger, bool logToDb)
    {
        var pipes = PrepareDataForReport();
        if (logToDb)
            dbLogger.Log("pipes finded");
        else
            fileLogger.Log("pipes finded");
        var report = CreateReport(pipes);
        if (logToDb)
            dbLogger.Log("report created");
        else
            fileLogger.Log("report created");
        RenderReportOnForm(report);
        if (logToDb)
            dbLogger.Log("repord rendered");
        else
            fileLogger.Log("repord rendered");
    }
}


#region other code

partial class ReportForm
{
    private object PrepareDataForReport()
    {
        throw new NotImplementedException();
    }
    private object CreateReport(object pipes)
    {
        throw new NotImplementedException();
    }
    private void RenderReportOnForm(object report)
    {
        throw new NotImplementedException();
    }
}

class DbLogger
{
    public void Log(string text)
    {
        // ...
    }
}
class FileLogger
{
    public void Log(string text)
    {
        // ...
    }
}
#endregion other code
/* Задача:
  * Упроститькод.
* В коде представлен метод, реализующий сценарий по формированию 
  * и выводу отчета пользователю.
  * Для каждого действия в методе реализовано логирование.
  * При этом, реализовано 2 логера. Один пишет в БД, другой в файл. 
  * Сами логгеры создаются где то выше (в вызывающем коде). 
  * Там же принимается решение, какой логгер следует использовать в данный момент. 
  * В таком виде код страдает от постояного повторения условия по выбору логгера. 
  * На этом фоне сложно прочитать бизнес-логику.
  * Можно ли как-то оптимизировать этот код?
  * Можно ли вообще отделить логирование от бизнес логики, сделав код максимально чистым?
* */

partial class ReportForm
{
    public void buttonShowReportClick(DbLoggerdbLogger, FileLoggerfileLogger, bool logToDb)
    {
        var pipes = PrepareDataForReport();
        if (logToDb)
            dbLogger.Log("pipes finded");
        else
            fileLogger.Log("pipes finded");
        var report = CreateReport(pipes);
        if (logToDb)
            dbLogger.Log("report created");
        else
            fileLogger.Log("report created");
        RenderReportOnForm(report);
        if (logToDb)
            dbLogger.Log("repord rendered");
        else
            fileLogger.Log("repord rendered");
    }
}


#region other code

partial class ReportForm
{
    private object PrepareDataForReport()
    {
        throw new NotImplementedException();
    }
    private object CreateReport(object pipes)
    {
        throw new NotImplementedException();
    }
    private void RenderReportOnForm(object report)
    {
        throw new NotImplementedException();
    }
}

class DbLogger
{
    public void Log(string text)
    {
        // ...
    }
}
class FileLogger
{
    public void Log(string text)
    {
        // ...
    }
}
#endregion other code




staticclassTest
  {
    //Вопрос: что выведется в консоль и почему?

class Order
{
    public int Id;
    public string Status;
}

public static void Execute1()
{
    var orders = CreateNewOrders(1, 2);
    var ord1 = orders.First(o => o.Id == 1);
    ord1.Status = "В доставке";

    foreach (var ord in orders)
    {
        Console.WriteLine($"id = {ord.Id}, status = {ord.Status}");
    }
}

private static IEnumerable<Order> CreateNewOrders(params int[] orderIDs)
{
    return orderIDs.Select(id => new Order { Id = id, Status = "В сборке" });
}

  }

namespace Test_Linq
{

    public class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
    }

    class Test
    {

        static public void Execute()
        {
            var apple = new Product { Name = "Apple" };
            var orange = new Product { Name = "Orange" };
            var bread = new Product { Name = "Bread" };

            var customers = new[]
            {
        new Customer{Name = "Peter", Orders = new[]
        {
            new Order { Product = apple, Quantity = 10},
            new Order { Product = orange, Quantity = 5} }.ToList()
        },
        new Customer{Name = "John", Orders = new[]
        {
            new Order { Product = bread, Quantity = 5},
            new Order { Product = orange, Quantity = 2} }.ToList()
        },
        new Customer{Name = "Mary", Orders = new[]
        {
            new Order { Product = apple, Quantity = 10} }.ToList()
        }
}.ToList();
            Console.WriteLine("Linq test");

            //select customers having orders with Quantity > 5

            //for each customer select his name and the names of the product he bought

        }

    }
}

// Задача: В примере представлен типичный метод редактирования модели. В приведенном случае - это данные клиента
// Прочитайте и оцените этот код. Можно ли улучшить читаемость и поддерживаемость этого кода.

public class Customer
{
    public Guid Id;
    public string Fio;
    public DateTimeRegistryDate;
    public DateTimeBirthDate;
    public int Age;
}

class CustomerForm
{
    public Customer EditCustomer(Guid id, string f, DateTime b)
    {
        #region Получениеклиентаиз БД
        OracleConnectioncn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=some.db)(PORT=1234))(CONNECT_DATA=(SID=someSid)));Persist Security Info=True;User ID=someUser;Password=somePass;");
        OracleCommand c = cn.CreateCommand();
        c.CommandText = $"select FIO, REG_DATE, BIRTH_DATE from CUSTOMERS where CUSTOMER_ID = '{id}'";
        DataSet d = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter(c);
        da.Fill(d);
        if (d.Tables[0].Rows.Count == 0)
        {
            throw new Exception("Клиентненайден");
        }
        Customer с2 = new Customer();
        с2.Fio = d.Tables[0].Rows[0]["FIO"].ToString();
        с2.RegistryDate = Convert.ToDateTime(d.Tables[0].Rows[0]["REG_DATE"]);
        с2.BirthDate = Convert.ToDateTime(d.Tables[0].Rows[0]["BIRTH_DATE"]);
        с2.Age = DateTime.Now.Year - с2.BirthDate.Year - 1;
        if ((DateTime.Now.Month > с2.BirthDate.Month) || ((DateTime.Now.Month == с2.BirthDate.Month) && (DateTime.Now.Day >= с2.BirthDate.Day)))
            с2.Age++;
        cn.Close();
        #endregion Получение клиента из БД
        #region Проверки корректности данных для редактирования
        if (f == null || f.Trim() == "")
            throw new Exception("Неуказано ФИО");
        if (f.ToLower() == "администратор")
            thrownewException("Это имя зарезервировано для администратора");
        if (b < с2.RegistryDate)
            thrownewException("Указана неверная дата рождения");
        #endregion Проверки корректности данных для редактирования
        #region Редактирование клиента
        с2.Fio = f;
        с2.BirthDate = b;
        с2.Age = DateTime.Now.Year - с2.BirthDate.Year - 1;
        if ((DateTime.Now.Month > с2.BirthDate.Month) || ((DateTime.Now.Month == с2.BirthDate.Month) && (DateTime.Now.Day >= с2.BirthDate.Day)))
            с2.Age++;
        #endregion Редактирование клиента
        #region Сохранение в БД
        cn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=some.db)(PORT=1234))(CONNECT_DATA=(SID=someSid)));Persist Security Info=True;User ID=someUser;Password=somePass;");
        c = cn.CreateCommand();
        c.CommandText = $"update CUSTOMERS set FIO = '{с2.Fio}', BIRTH_DATE = to_date('{с2.BirthDate:dd.MM.yyyy}', 'dd.mm.yyyy') where CUSTOMER_ID = '{id}'";
        c.ExecuteNonQuery();
        cn.Close();
# endregionСохранение в БД
        ShowMessage("Изменение выполнено");
        return с2;
    }

    #region other code 
    private void ShowMessage(string v)
    {
        throw new NotImplementedException();
    }
    #endregion other code 
}

--таблица "PIPES"
/*
PIPE_NUM |   OPERATION_TIME   |
-------------------------
23-0001	|  01.01.2023 11:00  |
23-0002	|  02.01.2023 12:00  |
23-0001	|  03.01.2023 10:00  | !
23-0003	|  04.01.2023 15:00  |
23-0004	|  05.01.2023 09:00  |
23-0002	|  06.01.2023 17:00  | !
23-0003	|  07.01.2023 16:00  | 
-------------------------
*/

-- дано SQL
CREATE TABLE pipes(PIPE_NUM varchar, OPR_TIME timestamp);
INSERT INTO pipes VALUES('23-0001', '01.01.2023 11:00');
INSERT INTO pipes VALUES('23-0002', '02.01.2023 12:00');
INSERT INTO pipes VALUES('23-0001', '03.01.2023 10:00'); --повтор
INSERT INTO pipes VALUES('23-0003', '04.01.2023 15:00');
INSERT INTO pipes VALUES('23-0004', '05.01.2023 09:00');
INSERT INTO pipes VALUES('23-0002', '06.01.2023 11:00'); --повтор
INSERTINTOpipesVALUES('23-0003', '07.01.2023 12:00'); --повтор, но за пределами диапазона

-- задача: задача: найти все трубы, которые принимались повторно с 03.01.2023 по 06.01.2023

select PIPE_NUM, max(OPR_TIME) from PIPES where PIPE_NUM in(
select PIPE_NUM from PIPES where OPR_TIME>='03.01.2023' and OPR_TIME<'07.01.2023')
and OPR_TIME<'07.01.2023'
group by PIPE_NUM
havingcount(*)>1;

/*-- задача: найти все трубы, которые принимались повторно с 03.01.2023 по 06.01.2023. Должныбыть 23-0001 и 23-0002
select PIPE_NUM from PIPES where PIPE_NUM in 
  (
select PIPE_NUM from PIPES where OPERATION_TIME >to_date('03.01.2023', 'dd.mm.yyyy') and OPR_TIME <to_date('07.01.2023', 'dd.mm.yyyy')
  )
group by PIPE_NUM having count(*)>1*/













