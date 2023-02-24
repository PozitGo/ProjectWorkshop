using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР1
{
    public interface ICar
    {
        public void PrintName();
    }

    public class Ford : ICar
    {
        public void PrintName() => Console.WriteLine("Ford");
    }

    public class Toyota : ICar
    {
        public void PrintName() => Console.WriteLine("Toyota");
    }

    public class Lexus : ICar
    {
        public void PrintName() => Console.WriteLine("Lexus");
    }

    public interface IEngine
    {
        public void PrintPower();
    }

    public interface IColor
    {
        public void PrintColor();
    }

    public class FordEngine : IEngine
    {
        public void PrintPower() => Console.WriteLine("Ford Engine 4.4");
    }

    public class ToyotaEngine : IEngine
    {
        public void PrintPower() => Console.WriteLine("Toyota Engine 3.2");
    }

    public class LexusEngine : IEngine
    {
        public void PrintPower() => Console.WriteLine("Lexus Engine 8.2");
    }

    public class FordColor : IColor
    {
        public void PrintColor() => Console.WriteLine("Ford Color - Red");
    }

    public class ToyotaColor : IColor
    {
        public void PrintColor() => Console.WriteLine("Toyota Color - Blue");
    }

    public class LexusColor : IColor
    {
        public void PrintColor() => Console.WriteLine("Lexus Color - Black");
    }

    public interface ICarFactory
    {
        public ICar CreateCar();
        public IEngine CreateEngine();
        public IColor CreateColor();
    }

    public class FordFactory : ICarFactory
    {
        public ICar CreateCar() => new Ford();

        public IEngine CreateEngine() => new FordEngine();

        public IColor CreateColor() => new FordColor();
    }

    public class ToyotaFactory : ICarFactory
    {
        public ICar CreateCar() => new Toyota();

        public IEngine CreateEngine() => new ToyotaEngine();

        public IColor CreateColor() => new ToyotaColor();
    }

    public class LexusFactory : ICarFactory
    {
        public ICar CreateCar() => new Lexus();

        public IEngine CreateEngine() => new LexusEngine();

        public IColor CreateColor() => new LexusColor();
    }

    public class ClientCar
    {
        private ICar myCar;
        private IEngine myEngine;
        private IColor myColor;

        public ClientCar(ICarFactory factory)
        {
            myCar = factory.CreateCar();
            myEngine = factory.CreateEngine();
            myColor = factory.CreateColor();
        }
        public void Run()
        {
            myCar.PrintName();
            myEngine.PrintPower();
            myColor.PrintColor();
        }
    }
}
