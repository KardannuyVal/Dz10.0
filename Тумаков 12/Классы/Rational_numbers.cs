using System;

namespace Тумаков_12
{
    internal class Rational_numbers
    {
        private double numerator {  get; set; }
        private double denominator { get; set; }
        public Rational_numbers(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            else
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
        }
        public Rational_numbers(double numerator) 
        {
            this.numerator = numerator;
        }
        public override bool Equals(object obj)
        {
            if (obj is Rational_numbers number)
            {
                if (numerator == number.numerator && denominator == number.denominator)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(Rational_numbers number_1, Rational_numbers number_2)
        {
            return number_1.Equals(number_2);
        }
        public static bool operator !=(Rational_numbers number_1, Rational_numbers number_2)
        {
            return !number_1.Equals(number_2);
        }
        public static bool operator <(Rational_numbers number_1, Rational_numbers number_2)
        {
            return (number_1.numerator / number_1.denominator < number_2.numerator / number_2.denominator);
        }
        public static bool operator >(Rational_numbers number_1, Rational_numbers number_2)
        {
            return (number_1.numerator / number_1.denominator > number_2.numerator / number_2.denominator);
        }
        public static bool operator <=(Rational_numbers number_1, Rational_numbers number_2)
        {
            return (number_1.numerator / number_1.denominator <= number_2.numerator / number_2.denominator);
        }
        public static bool operator >=(Rational_numbers number_1, Rational_numbers number_2)
        {
            return (number_1.numerator / number_1.denominator >= number_2.numerator / number_2.denominator);
        }
        public static Rational_numbers operator +(Rational_numbers number_1, Rational_numbers number_2)
        {
            return new Rational_numbers(number_1.numerator * number_2.denominator + number_2.numerator * number_1.denominator,
                number_1.denominator * number_2.denominator);
        }

        public static Rational_numbers operator -(Rational_numbers number_1, Rational_numbers number_2)
        {
            return new Rational_numbers(number_1.numerator * number_2.denominator - number_2.numerator * number_1.denominator,
                number_1.denominator * number_2.denominator);
        }

        public static Rational_numbers operator ++(Rational_numbers number)
        {
            return new Rational_numbers(number.numerator + number.denominator, number.denominator);
        }

        public static Rational_numbers operator --(Rational_numbers number)
        {
            return new Rational_numbers(number.numerator - number.denominator, number.denominator);
        }
        public static Rational_numbers operator *(Rational_numbers number_1, Rational_numbers number_2)
        {
            return new Rational_numbers(number_1.numerator * number_2.numerator, number_1.denominator * number_2.denominator);
        }

        public static Rational_numbers operator /(Rational_numbers number_1, Rational_numbers number_2)
        {
            if(number_1.denominator == 0 || number_2.denominator == 0)
            {
                return new Rational_numbers(0);
            }
            else
            {
                return new Rational_numbers(number_1.numerator * number_2.denominator, number_1.denominator * number_2.numerator);
            }
        }

        public static Rational_numbers operator %(Rational_numbers number_1, Rational_numbers number_2)
        {
            if (number_1.denominator == 0 || number_2.denominator == 0)
            {
                return new Rational_numbers(0);
            }
            else
            {
                return new Rational_numbers((number_1.numerator / number_1.denominator) % (number_2.numerator / number_2.denominator));
            }
        }
        public static implicit operator int(Rational_numbers number)
        {
            return (int)(number.numerator / number.denominator);
        }

        public static implicit operator float(Rational_numbers number)
        {
            return (float)(number.numerator / number.denominator);
        }
     
        public override string ToString()
        {
            return $"Дробь {numerator} / {denominator}";
        }
    }
}
