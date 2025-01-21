using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tumakov_DZ.Classes;

namespace Tumakov_DZ
{
    [DeveloperInfo("Almaz")]
    public class RationalNumber
    {
        public int numerator;
        public int denominator;
        public RationalNumber(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            Simplify();
        }
        public void Simplify()
        {
            int gcd = NOD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;


            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }
        public int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static public bool operator ==(RationalNumber number1, RationalNumber number2)
        {
            if (ReferenceEquals(number1, number2))
            {
                return true;
            }
            if (ReferenceEquals(number1, null) || ReferenceEquals(number2, null))
            {
                return false;
            }
            return number1.numerator * number2.denominator == number2.numerator * number1.denominator;

        }
        static public bool operator !=(RationalNumber number1, RationalNumber number2)
        {
            return !(number1 == number2);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is RationalNumber))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override int GetHashCode()
        {
            return (numerator, denominator).GetHashCode();
        }
        static public bool operator <(RationalNumber number1, RationalNumber number2)
        {
            if (number1.numerator * number2.denominator < number1.denominator * number2.numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool operator >(RationalNumber number1, RationalNumber number2)
        {
            return !(number1 < number2);
        }
        static public bool operator <=(RationalNumber number1, RationalNumber number2)
        {
            if (number1.numerator * number2.denominator <= number1.denominator * number2.numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool operator >=(RationalNumber number1, RationalNumber number2)
        {
            return !(number1 <= number2);
        }
        static public RationalNumber operator +(RationalNumber number1, RationalNumber number2)
        {
            RationalNumber answer = new RationalNumber((number1.numerator * number2.denominator) + (number2.numerator * number1.denominator),
                (number1.denominator * number2.denominator));
            return answer;
        }
        static public RationalNumber operator -(RationalNumber number1, RationalNumber number2)
        {
            RationalNumber answer = new RationalNumber((number1.numerator * number2.denominator) - (number2.numerator * number1.denominator),
                (number1.denominator * number2.denominator));
            return answer;
        }
        static public RationalNumber operator ++(RationalNumber number)
        {
            return new RationalNumber(number.numerator + number.denominator, number.denominator);
        }
        static public RationalNumber operator --(RationalNumber number)
        {
            return new RationalNumber(number.numerator - number.denominator, number.denominator);
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public static implicit operator RationalNumber(float number)
        {
            int denominator = 1;
            while (number % 1 != 0)
            {
                number *= 10;
                denominator *= 10;
            }
            int numerator = (int)number;
            return new RationalNumber(numerator, denominator);
        }
        public static implicit operator RationalNumber(int number)
        {
            return new RationalNumber(number, 1);
        }
        public static explicit operator int(RationalNumber number)
        {
            return number.numerator / number.denominator;
        }
        public static explicit operator float(RationalNumber number)
        {
            return (float)number.numerator / number.denominator;
        }
        public static RationalNumber operator *(RationalNumber number1, RationalNumber number2)
        {
            return new RationalNumber(number1.numerator * number2.numerator, number1.denominator * number2.denominator);
        }
        public static RationalNumber operator /(RationalNumber number1, RationalNumber number2)
        {
            return new RationalNumber(number1.numerator * number2.denominator, number1.denominator * number2.numerator);
        }
        public static RationalNumber operator %(RationalNumber number1, int denominator)
        {
            return (int)number1 % denominator;
        }

    }
}
