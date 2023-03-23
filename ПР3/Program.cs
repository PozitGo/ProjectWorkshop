namespace ПР3
{
    class Client
    {
        static void Main()
        {
            Player player;
            player = new PlayerOne(new Gun());
            player.Fire();

            player = new PlayerOne(new ShotGun());
            player.Fire();
        }
    }
}