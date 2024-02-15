﻿

// Задача: убрать дублирование кода в методах подсчета

using System.Drawing;

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
