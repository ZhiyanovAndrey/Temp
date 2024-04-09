using System;
using System.Drawing;

namespace Temp
{
    internal class CodReview
    {

    }

 
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
        //public void buttonShowReportClick(DbLoggerdbLogger, FileLoggerfileLogger, bool logToDb)
        //{
        //    var pipes = PrepareDataForReport();
        //    if (logToDb)
        //        dbLogger.Log("pipes finded");
        //    else
        //        fileLogger.Log("pipes finded");
        //    var report = CreateReport(pipes);
        //    if (logToDb)
        //        dbLogger.Log("report created");
        //    else
        //        fileLogger.Log("report created");
        //    RenderReportOnForm(report);
        //    if (logToDb)
        //        dbLogger.Log("repord rendered");
        //    else
        //        fileLogger.Log("repord rendered");
        //}
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








}
