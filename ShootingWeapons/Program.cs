namespace ShootingWeapons
{
    using Weapons;

    internal class Target
    {
        private int health;

        public Target(int initialHealth)
        {
            health = initialHealth;
        }

        public void Destroy(IWeapon weapon)
        {
            Console.WriteLine($"здоровье мишени: {health}");
            Console.WriteLine($"УВС оружия: {weapon.Damage * weapon.FireRate}\n");
            int shotCount = 0;
            
            while (health > 0)
            {
                shotCount++;
                health -= weapon.Damage;
                if (health < 0)
                    health = 0;
                Console.WriteLine($"Выстрел {shotCount}. Оставшееся здоровье {health}");


                Thread.Sleep((int)(1/ weapon.FireRate * 1000));
            }

            Console.WriteLine($"Мишень уничтожена. Количество выстрелов: {shotCount}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пистолет");
            Target tgt1 = new(100);
            tgt1.Destroy(Weapons.Create("Pistol"));
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Дробовик");
            Target tgt2 = new(250);
            tgt2.Destroy(Weapons.Create("Shotgun"));
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Винтовка");
            Target tgt3 = new(500);
            tgt3.Destroy(Weapons.Create("Rifle"));




        }
    }
}
