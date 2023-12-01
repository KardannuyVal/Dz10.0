
namespace Тумаков_12
{
    internal class Complex_number
    {
        private double real_number;
        private double complex_number;
        public Complex_number(double real_number, double complex_number)
        {
            this.real_number = real_number;
            this.complex_number = complex_number;
        }
        public override bool Equals(object obj)
        {
            if (obj is Complex_number number)
            {
                if (real_number == number.real_number && complex_number == number.complex_number)
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
        public static Complex_number operator +(Complex_number number_1, Complex_number number_2)
        {
            return new Complex_number(number_1.real_number + number_2.real_number, number_1.complex_number + number_2.complex_number);
        }
        public static Complex_number operator +(Complex_number number_1, double number_2)
        {
            return new Complex_number(number_1.real_number + number_2, number_1.complex_number);
        }
        public static Complex_number operator -(Complex_number number_1, Complex_number number_2)
        {
            return new Complex_number(number_1.real_number - number_2.real_number, number_1.complex_number - number_2.complex_number);
        }
        public static Complex_number operator -(Complex_number number_1, double number_2)
        {
            return new Complex_number(number_1.real_number - number_2, number_1.complex_number);
        }
        public static Complex_number operator *(Complex_number number_1, Complex_number number_2)
        {
            return new Complex_number((number_1.real_number * number_2.real_number) - (number_1.complex_number * number_2.complex_number),
                number_1.real_number * number_2.complex_number + number_1.complex_number * number_2.real_number);
        }
        public static Complex_number operator *(Complex_number number_1, double number_2)
        {
            return new Complex_number(number_1.real_number * number_2, number_1.complex_number * number_2);
        }
        public static bool operator ==(Complex_number number_1, Complex_number number_2)
        {
            return ((number_1.real_number == number_2.real_number) && (number_1.complex_number == number_2.complex_number));
        }
        public static bool operator !=(Complex_number number_1, Complex_number number_2)
        {
            return !((number_1.real_number == number_2.real_number) && (number_1.complex_number == number_2.complex_number));
        }
        public override string ToString()
        {
            return $"{real_number} + {complex_number}i";
        }
        
    }
}
