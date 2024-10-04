namespace Weapons
{
    public interface IWeapon
    {
        int Damage { get; }
        float FireRate { get; }
    }

    public static class Weapons
    {
        public static IWeapon Create(string name)
        {
            switch (name)
            {
                case "Pistol":
                {
                    return new Pistol();
                }
                case "Shotgun":
                {
                    return new Shotgun();
                }
                case "Rifle":
                {
                    return new Rifle();
                }
                default:
                {
                    throw new ArgumentException($"Неизвестное оружие: {name}");
                }
            }
        }
    }

    internal class Pistol : IWeapon
    {
        public int Damage { get; } = 20;
        public float FireRate { get; } = 1.0f;
    }

    internal class Shotgun : IWeapon
    {
        public int Damage { get; } = 50;
        public float FireRate { get; } = 0.5f;
    }

    internal class Rifle : IWeapon
    {
        public int Damage { get; } = 30;
        public float FireRate { get; } = 5.0f;
    }
}
