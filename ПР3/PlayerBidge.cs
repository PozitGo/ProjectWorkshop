namespace ПР3
{
    abstract class Player
    {
        protected Weapon weapon;
        public Weapon Weapon
        {
            set { weapon = value; }
        }
        public Player(Weapon weapon) => Weapon = weapon;
        public abstract void Fire();
    }

    abstract class Weapon
    {
        public abstract void FireDamage();
    }

    class PlayerOne : Player
    {
        public PlayerOne(Weapon weapon) : base(weapon) => Weapon = weapon;
        public override void Fire()
        {
            Console.WriteLine("Игрок сделал выстрел");
            weapon.FireDamage();
        }
    }

    class Gun : Weapon
    {
        public override void FireDamage() => Console.WriteLine("Выстрел нанёс 15 урона");
    }

    class ShotGun : Weapon
    {
        public override void FireDamage() => Console.WriteLine("Выстрел нанёс 42 урона");
    }



}


