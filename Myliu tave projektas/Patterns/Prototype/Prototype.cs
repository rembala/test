using System;

namespace Myliu_tave_projektas.Patterns.Prototype
{
    partial class Program
    {
        static void Start()
        {
            ConcretePrototype prototype = new ConcretePrototype("25");
            ConcretePrototype clone = (ConcretePrototype)prototype.Clone();
            Console.WriteLine("Cloned: {0} ", clone.id);
        }
    }

    internal abstract class Prototype
    {
        private readonly string m_id;

        protected Prototype(string id)
        {
            m_id = id;
        }

        public string id
        {
            get { return m_id; }
        }

        internal abstract Prototype Clone();
    }

    sealed internal class ConcretePrototype : Prototype
    {
        internal ConcretePrototype(string id)
            : base(id)
        {
        }

        internal override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}