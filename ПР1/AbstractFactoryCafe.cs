using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР1
{
    public interface ICafe
    {
        public void PrintDish();
    }

    public class Burger : ICafe
    {
        public void PrintDish() => Console.WriteLine("Блюдо - Бургер");
    }

    public class Potato : ICafe
    {
        public void PrintDish() => Console.WriteLine("Блюдо - Картошка");
    }

    public class Steak : ICafe
    {
        public void PrintDish() => Console.WriteLine("Блюдо - Стейк");
    }

    public interface IAdditives
    {
        public void PrintAdditives();
    }

    public class BurgerAdditives : IAdditives
    {
        public void PrintAdditives() => Console.WriteLine("Добавка - Картошка");
    }

    public class PotatoAdditives : IAdditives
    {
        public void PrintAdditives() => Console.WriteLine("Добавка - Соус  и зелень");
    }

    public class SteakAdditives : IAdditives
    {
        public void PrintAdditives() => Console.WriteLine("Добавка - Морская соль и овощи гриль");
    }
    public interface IDrink
    {
        public void PrintDrink();
    }

    public class BurgerDrink : IDrink
    {
        public void PrintDrink() => Console.WriteLine("Напиток - Спрайт");
    }

    public class PotatoDrink : IDrink
    {
        public void PrintDrink() => Console.WriteLine("Напиток - Кола");
    }

    public class SteakDrink : IDrink
    {
        public void PrintDrink() => Console.WriteLine("Напиток - Кофе");
    }

    public interface ICafeFactory
    {
        public ICafe CreateCafe();
        public IAdditives CreateAdditives();
        public IDrink CreateDrink();
    }

    public class BurgerFactory : ICafeFactory
    {
        public ICafe CreateCafe() => new Burger();
        public IAdditives CreateAdditives() => new BurgerAdditives();
        public IDrink CreateDrink() => new BurgerDrink();
    }

    public class PotatoFactory : ICafeFactory
    {
        public ICafe CreateCafe() => new Potato();
        public IAdditives CreateAdditives() => new PotatoAdditives();
        public IDrink CreateDrink() => new PotatoDrink();
    }

    public class SteakFactory : ICafeFactory
    {
        public ICafe CreateCafe() => new Steak();
        public IAdditives CreateAdditives() => new SteakAdditives();
        public IDrink CreateDrink() => new SteakDrink();
    }

    public class ClientCafe
    {
        private ICafe myCafe;
        private IAdditives myAdditives;
        private IDrink myDrink;

        public ClientCafe(ICafeFactory factory)
        {
            myCafe = factory.CreateCafe();
            myAdditives = factory.CreateAdditives();
            myDrink = factory.CreateDrink();
        }

        public void Run()
        {
            myCafe.PrintDish();
            myAdditives.PrintAdditives();
            myDrink.PrintDrink();
        }
    }
}
