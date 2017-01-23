using System;

namespace Myliu_tave_projektas.Patterns.AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    abstract class AbstractProductA
    {

    }

    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    class client
    {
        private readonly AbstractProductA m_abstractProductA;

        private readonly AbstractProductB m_abstractProductB;

        public client(AbstractFactory factory)
        {
            m_abstractProductA = factory.CreateProductA();
            m_abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            this.m_abstractProductB.Interact(m_abstractProductA);
        }
    }
    #region Products


    class ProductA1 : AbstractProductA
    {

    }

    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(GetType().Name + " Interacts with" + a.GetType().Name);
        }
    }

    class ProductA2 : AbstractProductA
    {
    }

    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }

    #endregion
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
