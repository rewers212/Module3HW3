using System;
using System.Net.Http.Headers;

namespace Module3HW3
{
   public class Class2
    {
        private int _rez;

        public Predicate<int> Calc(Func<int, int, int> r, int a, int b)
        {
            _rez = r.Invoke(a, b);
            return Result;
        }

        private bool Result(int x)
        {
            if (_rez % x == 0)
            {
                return true;
            }

            return false;
        }
    }
}
