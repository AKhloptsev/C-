using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRatio
{
    class Ratio
    {
        // numerator - числитель
        // denominator - знаменатель
        private long numerator, denominator;

        // метод для нахождения наибольшего общего делителя
        private long gcd()
        {
            long a, b, t;
            a = numerator;
            b = denominator;
            if (a < b)
            {
                t = a;
                a = b;
                b = t;
            }

            while (a != b)
            {
                t = a % b;
                if(t == 0)
                    break;
                a = b;
                b = t;
            }
            return b;
        }

        // конструктор с параметрами
        public Ratio(long _m, long _n)
        {
            numerator = _m;
            denominator = _n;
        }

        //конструктор по умолчанию
        public Ratio():this(0, 1){}

        // перегрузка бинарного оператора +
        public static Ratio operator +(Ratio lho, Ratio rho)
        {
            Ratio tmp = new Ratio();
            tmp.numerator = lho.numerator * rho.denominator + lho.denominator * rho.numerator;
            tmp.denominator = lho.denominator * rho.denominator;
            long gdc = tmp.gcd();
            // делим на наибольший общий делитель
            tmp.numerator /= gdc;
            tmp.denominator /= gdc;
            return tmp;
        }

        // перегрузка бинарного оператора -
        public static Ratio operator -(Ratio lho, Ratio rho)
        {
            Ratio tmp = new Ratio();
            tmp.numerator = lho.numerator * rho.denominator - lho.denominator * rho.numerator;
            tmp.denominator = lho.denominator * rho.denominator;
            long gdc = tmp.gcd();
            if (gdc != 1)
            {
                // делим на наибольший общий делитель
                tmp.numerator /= gdc;
                tmp.denominator /= gdc;
            }
            return tmp;
        }

        // перегрузка метода GetHashCode (необходима при перегрузке оператора ==)
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // перегрузка метода ToString для класса Ratio
        public override string ToString()
        {
            if(numerator < 0 || denominator < 0)
                return String.Format("-{0}/{1}", Math.Abs(numerator), Math.Abs(denominator));
            if(numerator < 0 && denominator < 0)
                return String.Format("{0}/{1}", Math.Abs(numerator), Math.Abs(denominator));
            else
                return String.Format("{0}/{1}", numerator, denominator);
        }

        // перегрузка метода Equals (для перегрузки оператора ==)
        public override bool Equals(object obj)
        {
            // преобразуем obj в Ratio
            Ratio o = obj as Ratio;
            long gdc1 = this.gcd();
            long gdc2 = o.gcd();
            if(gdc2 != 1 && gdc1 != 1)
            {
                // делим на наибольший общий делитель
                o.numerator /= gdc2;
                o.denominator /= gdc2;
                numerator /= gdc1;
                denominator /= gdc1;
            }

            if (numerator == o.numerator && denominator == o.denominator)
                return true;
            return false;
        }

        // перегрузка оператора ==
        public static bool operator ==(Ratio objLeft, Ratio objRight)
        {
            // наибольший общий делитель
            long gdc1 = objLeft.gcd();
            long gdc2 = objRight.gcd();
            if(gdc2 != 1 || gdc1 != 1)
            {
                // делим на наибольший общий делитель
                objRight.numerator /= gdc2;
                objRight.denominator /= gdc2;
                objLeft.numerator /= gdc1;
                objLeft.denominator /= gdc1;
            }

            if (objLeft.numerator == objRight.numerator && objLeft.denominator == objRight.denominator)
                return true;
            return false;
        }

        // перегрузка оператора !=
        public static bool operator !=(Ratio objLeft, Ratio objRight)
        {
            // наибольший общий делитель
            long gdc1 = objLeft.gcd();
            long gdc2 = objRight.gcd();
            if (gdc2 != 1 || gdc1 != 1)
            {
                // делим на наибольший общий делитель
                objRight.numerator /= gdc2;
                objRight.denominator /= gdc2;
                objLeft.numerator /= gdc1;
                objLeft.denominator /= gdc1;
            }

            if (objLeft.numerator != objRight.numerator && objLeft.denominator != objRight.denominator)
                return true;
            return false;
        }

        // явное преобразование
        // выводит длину вектора
        public static explicit operator double(Ratio obj)
        {
            return Math.Sqrt(obj.numerator * obj.numerator + obj.denominator * obj.denominator);
        }

    }
}
