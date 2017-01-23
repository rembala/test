using System;

namespace Myliu_tave_projektas.Patterns.Prototype
{
    internal class StartExecution
    {
        internal void StartExec()
        {
            var stormCommander = new Commander();
            var Infantry = new Infarntry();

            var stormCommander1 = stormCommander.Clone() as Commander;
            var infrantry2 = Infantry.Clone() as Infarntry;

            if (stormCommander1 != null)
                Console.WriteLine("Firepower {0}, Amor: {1}", stormCommander1.FirePower, stormCommander1.Amor);

            if (infrantry2 != null)
                Console.WriteLine("Firepower: {0}, Amor: {1]", infrantry2.FirePower, infrantry2.Amor);
        }
    }

    internal abstract class StormTrooper : ICloneable
    {
        public int FirePower { get; set; }
        public int Amor { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    internal sealed class Commander : StormTrooper
    {
        public Commander()
        {
            this.Amor = 15;
            this.FirePower = 20;
        }
    }

    internal class Infarntry : StormTrooper
    {
        public Infarntry()
        {
            this.FirePower = 10;
            this.Amor = 9;
        }
    }
}

