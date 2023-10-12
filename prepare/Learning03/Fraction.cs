using System;
using System.Reflection.Metadata.Ecma335;


public class Fraction
{
    private int _top;
    private int _bottom;

    public int GetTopNumber()
    {
        return _top;
    }
    public int GetBottomNum()
    {
        return _bottom;
    }

    public void SetTopNum(int top)
    {
        _top = top;
    }

    public void SetBottomNum(int bottom)
    {
        _bottom = bottom;
    }


// public int Numerator
// {
//     get { return _top; }
//     set { _top = value; }
// }

// public int Denominator
// {
//     get { return _bottom; }
//     set { _bottom = value; }
// }

    public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

    public Fraction(int numerator)
        {
            _top = numerator;
            _bottom = 1;
        }  

    public Fraction(int numerator, int denominator)
        {
            _top = numerator;
            _bottom = denominator;
        } 

    public string GetFractionString()
        {
           string topOverBottom = $"{_top} / {_bottom}";
           return topOverBottom;
        } 

            public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }        
}