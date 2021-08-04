using System;
using System.Net.Http.Headers;

namespace Module3HW3
{
   public class Class2
    {
        private int _rez;

        public Class2()
        {
            EventRefResult += Result;
        }

        public delegate int RefPow(int x, int y);
        public delegate bool RefResult(int x);

        public event RefResult EventRefResult;

        public RefResult Calc(RefPow r, int a, int b)
        {
            _rez = r.Invoke(a, b);
            return new RefResult(Result);
        }

        public bool Result(int x)
        {
            if (_rez % 2 == 0)
            {
                return true;
            }

            return false;
        }

        private void Handler(int a)
        {
            EventRefResult?.Invoke(a);
        }
    }
}
