namespace ПР1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            ClientCar clientCar = new ClientCar(new ToyotaFactory());
            clientCar.Run();

            Console.WriteLine();
            Console.WriteLine("Задание 2");
            ClientCafe clientCafe = new ClientCafe(new BurgerFactory());
            clientCafe.Run();
        }
    }
}