using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Xml.XPath;
public class Fraction
{

    private int top_number;
    private int bottom_number;
    public Fraction()
    {
        top_number = 1;
        bottom_number = 1;
    }
    public Fraction(int wholeNumber)
    {
        top_number= wholeNumber;
        bottom_number=1;
    }
    public Fraction(int number_top, int number_bottom)
    {
        top_number = number_top;
        bottom_number = number_bottom;
    }
    public int GetTop()
    {
        return top_number;
    }
    public void SetTop(int number)
    {
        top_number = number;


    }
    public int GetBottom()
    {
        return bottom_number;
    }
    public void SetBottom(int number2)
    {
        bottom_number = number2;
    }
    public string GetFractionString()
    {
        return $"{top_number}/{bottom_number}";
    }
    public double GetDecimalValue()
    {
        return (double)top_number / bottom_number;

    }


}