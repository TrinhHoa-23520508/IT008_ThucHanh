using System;
namespace Bai04
{
    class Program
    {
        public static void Main(string[] args)
        {
            Fraction a = new Fraction();
            Fraction b = new Fraction();
            Console.WriteLine("Phan so a: ");
            a.FractionImport();
            Console.WriteLine("Phan so b: ");
            b.FractionImport();
            Console.Write("a + b = ");
            (a + b).FractionExport();
            Console.Write("a - b = ");
            (a - b).FractionExport();
            Console.Write("a * b = ");
            (a * b).FractionExport();
            Console.Write("a / b = ");
            (a / b).FractionExport();
            List<Fraction> ListFraction = new List<Fraction>();
            int n;
            Console.Write("Enter the number of Fractions: ");
            n = int.Parse(Console.ReadLine());
            for(int i =  0; i< n; i++)
            {
                Fraction temp = new Fraction();
                Console.WriteLine($"Enter Fraction {i + 1} ");
                temp.FractionImport();
                ListFraction.Add(temp);
            }
            Console.Write("The max fraction in ListFraction is: ");
            ListFraction.Max<Fraction>().FractionExport();
            Console.Write("The ListFraction after sort is: ");
            ListFraction.Sort();
            foreach(Fraction temp in ListFraction)
            {
                temp.FractionExport();
            }
 
        }

    }
    public class Fraction : IComparable<Fraction>
    {
        int _numerator;
        int _denominator;
        public int Numerator
        {
            get => _numerator;
            protected set
            {
                _numerator = value;
            }
        }
        public int Denominator
        {
            get => _denominator;
            set
            {
                if (value > 0)
                {
                    _denominator = value;
                }
                else throw new Exception("Denominator cannot be zero!");
            }
        }
        
        public Fraction(int numerator = 0, int denominator = 1)
        {
            this._denominator = denominator;
            this._numerator = numerator;
        }
        public void FractionImport()
        {
            Console.Write("- Please enter numerator: numerator = ");
            _numerator = int.Parse(Console.ReadLine());
            Console.Write("- Please enter denominator: denominator = ");
            _denominator = int.Parse(Console.ReadLine());
            while(_denominator==0)
            {
                Console.WriteLine("Error! Denominator cannot be zero!");
                Console.Write("Please enter denominator again: denominator = ");
                _denominator = int.Parse(Console.ReadLine());
            }
            Simplify();
            Console.Clear();
        }
        public void  FractionExport()
        {
            if(_numerator==0)
            {
                Console.WriteLine(_numerator / _denominator);
            }    
            else
            {
                Console.WriteLine("{0}/{1}", _numerator, _denominator);
            }
        }
        void Simplify()
        {
            int temp;
            if(Math.Abs(_numerator)<Math.Abs(_denominator))
            {
                temp = Math.Abs(_numerator);
            }
            else
            {
                temp = Math.Abs(_denominator);
            }
            for(int i = temp; i>=1; i--)
            {
                if(_numerator%i==0&&_denominator%i==0)
                {
                    _numerator = _numerator / i;
                    _denominator = _denominator / i;
                    if((_numerator<0&&_denominator<0)||(_numerator>0&&_denominator<0))
                    {
                        _numerator *= -1;
                        _denominator *=-1;

                    }
                    break;
                }
            }

        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction result = new Fraction();
            result._numerator = a._numerator * b._denominator + a._denominator * b._numerator;
            result._denominator = a._denominator * b._denominator;
            result.Simplify();
            return result;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction result = new Fraction();
            result._numerator = a._numerator * b._denominator - a._denominator * b._numerator;
            result._denominator = a._denominator * b._denominator;
            result.Simplify();
            return result;
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction result = new Fraction();
            result._numerator = a._numerator * b._numerator;
            result._denominator = a._denominator * b._denominator;
            result.Simplify();
            return result;
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction result = new Fraction();
            result._numerator = a._numerator * b._denominator;
            result._denominator = a._denominator * b._numerator;
            result.Simplify();
            return result;
        }
        public int CompareTo(Fraction other)
        {
            return (this._numerator * other._denominator).CompareTo(this._denominator * other._numerator);

        }
    }


}
