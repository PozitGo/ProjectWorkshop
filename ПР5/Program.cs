namespace ПР5
{
    class Client
    {
        static void Main(string[] args)
        {
            Aggregate a = new ConcreteAggregate();

            a.Data();
            
            Iterator i = a.CreateIterator();

            object item = i.First();

            Console.WriteLine(item + " - Первый элемент");

            item = i.Next();

            Console.WriteLine(item = i.CurrentItem() + " - Текущий элемент");

            while (!i.IsDone())
            {
                item = i.Next();

                Console.WriteLine(item);
            }
        }
    }
}