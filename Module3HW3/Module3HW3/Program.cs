using System;
using System.Security.Cryptography.X509Certificates;

namespace Module3HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var p = new Program();
            var c1 = new Class1();
            var c2 = new Class2();
            c1.RefShow += p.Show;
            Func<int, int, int> refPow = c1.Pow;
            var rezCalc = c2.Calc(refPow, 9, 5);
            var flag = rezCalc.Invoke(4);
            c1.RefShow.Invoke(flag);
        }

        public void Show(bool e)
        {
            if (e == false)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
