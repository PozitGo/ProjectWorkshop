using System.Drawing;

namespace ПР1
{
    public interface ICPU
    {
        public void PrintName();
    }

    public class i512400f : ICPU
    {
        public void PrintName() => Console.WriteLine("Процессор - i512400f");
    }

    public class i913900KS : ICPU 
    {
        public void PrintName() => Console.WriteLine("Процессор - i913900KS");
    }

    public class i712700f : ICPU 
    {
        public void PrintName() => Console.WriteLine("Процессор - i712700f");
    }

    public interface IGHz
    {
        public void PrintGhz();
    }

    public class i512400fGhz : IGHz
    {
        public void PrintGhz() => Console.WriteLine("Базовая частота - 2.5ГГц");
    }

    public class i913900KSGhz : IGHz
    {
        public void PrintGhz() => Console.WriteLine("Базовая частота - 4.3ГГц");
    }

    public class i712700fGHz : IGHz
    {
        public void PrintGhz() => Console.WriteLine("Базовая частота - 3.6ГГц");
    }

    public interface INumberOfCores
    {
        public void PrintNumberOfCores();
    }

    public class i512400fNumberOfCores : INumberOfCores
    {
        public void PrintNumberOfCores() => Console.WriteLine("Количество ядер - 6");
    }

    public class i913900KSNumberOfCores : INumberOfCores
    {
        public void PrintNumberOfCores() => Console.WriteLine("Количество ядер - 16");
    }

    public class i712700fNumberOfCores : INumberOfCores
    {
        public void PrintNumberOfCores() => Console.WriteLine("Количество ядер - 12");
    }

    public interface INumberOfThreads
    {
        public void PrintNumberOfThreads();
    }

    public class i512400fNumberOfThreads : INumberOfThreads
    {
        public void PrintNumberOfThreads() => Console.WriteLine("Количество потоков - 12");
    }

    public class i913900KSNumberOfThreads : INumberOfThreads
    {
        public void PrintNumberOfThreads() => Console.WriteLine("Количество потоков - 32");
    }

    public class i712700fNumberOfThreads : INumberOfThreads
    {
        public void PrintNumberOfThreads() => Console.WriteLine("Количество потоков - 20");
    }

    public interface ICPUFactory
    {
        public ICPU CreateCPU();
        public INumberOfCores CreateCores();
        public INumberOfThreads CreateThreads();
    }

    public class i512400fFactory : ICPUFactory 
    {
        public ICPU CreateCPU() => new i512400f();
        public INumberOfCores CreateCores() => new i512400fNumberOfCores();
        public INumberOfThreads CreateThreads() => new i512400fNumberOfThreads();

    }

    public class i913900KSFactory : ICPUFactory
    {
        public ICPU CreateCPU() => new i913900KS();
        public INumberOfCores CreateCores() => new i913900KSNumberOfCores();
        public INumberOfThreads CreateThreads() => new i913900KSNumberOfThreads();
    }

    public class i712700fFactory : ICPUFactory
    {
        public ICPU CreateCPU() => new i712700f();
        public INumberOfCores CreateCores() => new i712700fNumberOfCores();
        public INumberOfThreads CreateThreads() => new i712700fNumberOfThreads();
    }

    public class UseCPU
    {
        public static void Use(ICPUFactory factory)
        {
            var myCPU = factory.CreateCPU();
            myCPU.PrintName();
            var myCores = factory.CreateCores();
            myCores.PrintNumberOfCores();
            var myTheards = factory.CreateThreads();
            myTheards.PrintNumberOfThreads();
        }
    }
}
