using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace LinearProblem
{
    public class Rational : IComparable
    {
        [JsonProperty]
        private long z;
        [JsonProperty]
        private long n;
        public Rational(long z)
        {
            this.z = z;
            this.n = 1;
        }
        public Rational(long z, long n)
        {
            if (n == 0) throw new Exception("Denominator cannot be zero.");

            this.z = z;
            this.n = n;

            Simplify();
        }
        public Rational()
        {
            this.z = 0;
            this.n = 1;
        }
        public static Rational operator +(Rational a) => a;
        public static Rational operator -(Rational a) => new Rational(-a.z, a.n);
        public static Rational operator +(Rational a, Rational b) => new Rational(a.z * b.n + b.z * a.n, a.n * b.n);
        public static Rational operator -(Rational a, Rational b) => a + (-b);
        public static Rational operator *(Rational a, Rational b) => new Rational(a.z * b.z, a.n * b.n);
        public static Rational operator /(Rational a, Rational b)
        {
            if (b.z == 0) throw new DivideByZeroException();
            return new Rational(a.z * b.n, a.n * b.z);
        }
        public static bool operator ==(Rational a, long i)
        {
            return a.z % a.n == 0 && a.z / a.n == i;
        }
        public static bool operator !=(Rational a, long i)
        {
            return !(a.z % a.n == 0 && a.z / a.n == i);
        }
        public static bool operator ==(Rational a, Rational b)
        {
            return a.z == b.z && a.n == b.n;
        }
        public static bool operator !=(Rational a, Rational b)
        {
            return !(a.z == b.z && a.n == b.n);
        }
        public static bool operator <(Rational a, Rational b) => a.z * b.n < b.z * a.n;
        public static bool operator >(Rational a, Rational b) => a.z * b.n > b.z * a.n;
        public static bool operator >=(Rational a, Rational b) => a.z * b.n >= b.z * a.n;
        public static bool operator <=(Rational a, Rational b) => a.z * b.n <= b.z * a.n;

        public static bool operator <(Rational a, long b) => a.z < b * a.n;
        public static bool operator >(Rational a, long b) => a.z > b * a.n;
        public static bool operator >=(Rational a, long b) => a.z >= b * a.n;
        public static bool operator <=(Rational a, long b) => a.z <= b * a.n;
        public override string ToString()
        {
            if (z == 0) return "0";
            if (n == 1) return z.ToString();
            return $"{z}/{n}";
        }
        private void Simplify()
        {
            long g = gcd(Math.Abs(this.n), Math.Abs(this.z));
            n /= g;
            z /= g;
            if (n < 0)
            {
                n = -n;
                z = -z;
            }
        }
        private long gcd(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }
            return a + b;
        }
        public int CompareTo(object obj)
        {
            return ((double)z / n).CompareTo(obj);
        }

        public static explicit operator double(Rational v)
        {
            return (double)v.z / v.n;
        }

        public static Rational Parse(string s)
        {
            long i;
            if (long.TryParse(s, out i))
            {
                return new Rational(i);
            }

            double d;
            
            if (double.TryParse(s, out d))
            {
                return new Rational((long)(d * 1000), 1000);
            }

            if (double.TryParse(s, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out d))
            {
                return new Rational((long)(d * 1000), 1000);
            }



            string pattern = @"[0-9]+[ ]*/[ ]*[0-9]+";
            if (Regex.IsMatch(s, pattern))
            {
                var sep = new string[] { "/", " " };
                string[] str = s.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                long z, n;
                if (long.TryParse(str[0], out z) && long.TryParse(str[1], out n))
                    return new Rational(z, n);
            }
            throw new Exception("Cant parse string to Rational");
        }
    }
}
