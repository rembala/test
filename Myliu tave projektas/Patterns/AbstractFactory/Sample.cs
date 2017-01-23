using System;
using System.Collections.Generic;

namespace Myliu_tave_projektas.Patterns.AbstractFactory
{
    public interface IVehicleFactory
    {
        Vehicle CreateEconomyCar();
        Vehicle CreateRacingCar();
        Vehicle CreateSUV();
    }

    public abstract class Vehicle
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Body { get; set; }
        public int Doors { get; set; }

        public List<string> Accessories = new List<string>();
        public abstract void ShowInfo();
    }

    class ForFactory : IVehicleFactory
    {
        public Vehicle CreateEconomyCar()
        {
            throw new NotImplementedException();
        }

        public Vehicle CreateRacingCar()
        {
            throw new NotImplementedException();
        }

        public Vehicle CreateSUV()
        {
            return new FordExplorer();
        }
    }

    public class MitsubishiFactory : IVehicleFactory
    {
        public Vehicle CreateEconomyCar()
        {
            throw new NotImplementedException();
        }

        public Vehicle CreateRacingCar()
        {
            throw new NotImplementedException();
        }

        public Vehicle CreateSUV()
        {
            throw new NotImplementedException();
        }
    }

    public class FordExplorer : Vehicle
    {
        public FordExplorer()
        {
            Model = "Ford Explorer";
            Engine = "4.0 L Cologne V6";
            Transmission = "5-speed M50D-R1 manual";
            Body = "SUV";
            Doors = 5;
            Accessories.Add("Car Cover");
            Accessories.Add("Sun Shade");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Engine: {0}", Engine);
            Console.WriteLine("Body: {0}", Body);
            Console.WriteLine("Doors: {0}", Doors);
            Console.WriteLine("Transmission: {0}", Transmission);
            Console.WriteLine("Accessories:");
            foreach (var accessory in Accessories)
            {
                Console.WriteLine("\t{0}", accessory);
            }
        }
    }

}
