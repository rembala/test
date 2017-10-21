using System;

namespace Myliu_tave_projektas.Patterns.Builder
{
    class MyClass
    {

    }

    partial class Program
    {
        static void Main(string[] args)
        {
            MainInitialize();

            Console.ReadLine();
        }

        internal interface f { void he(); }
        abstract internal class c { public abstract void testas(); }
        sealed internal partial class test1 : c, f
        {
            public void he()
            {
                throw new NotImplementedException();
            }

            public override void testas()
            {
                throw new NotImplementedException();
            }

            internal void TestMethod()
            {

            }
        }

        sealed internal partial class test1
        {
            internal void TestMethod2()
            {

            }
        }
        sealed internal partial class test1
        {
            internal void TestMethod3()
            {

            }
        }
    }
}