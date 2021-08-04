using System;

namespace Module3HW3
{
    public class Class1
    {
        public Class1()
        {
            EventPow += Pow;
        }

        public delegate void RefShow(bool b);
        public event Class2.RefPow EventPow;
        public int Pow(int x, int y)
        {
            return x * y;
        }

        private void Handler(int a, int b)
        {
            EventPow?.Invoke(a, b);
        }
    }
}
