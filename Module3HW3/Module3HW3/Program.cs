using System;
using System.Security.Cryptography.X509Certificates;

namespace Module3HW3
{
    public class Program
    {
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

        public static void Main(string[] args)
        {
            var q = new Class2();
            var r = new Class1();
            var p = new Program();
            q.Calc(r.Pow, 9, 7);
            p.Show(q.Result(8));
        }
    }
}
