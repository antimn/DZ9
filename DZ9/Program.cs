namespace DZ9;

public abstract class Program
{
    private static int _attackMagic;
    private static int _attackAxe;
    private static int _attackBow;
    private static int _additionalDamage; //Bonus damage
    


    public static void Main(string[] args)

    {
        List<Unit> units = new List<Unit>();
        _attackMagic = 10;
        _additionalDamage = 1;
        units.Add(new Mage { atackVar = "Use MAGIC", atackPower = _attackMagic + _additionalDamage });
        _attackAxe = 12;
        units.Add(new Warrior { atackVar = "Attack with AXE", atackPower = _attackAxe });
        _attackBow = 15;
        units.Add(new Hunter { atackVar = "Attack with BOW", atackPower = _attackBow });

        foreach (Unit unit in units)
        {
            Console.WriteLine($"Hero: {unit.atackVar}, Damage {unit.atackPower}");
            unit.Attack();
            Console.WriteLine();
        }

        Rogue rogue = new Rogue();
        rogue.UseSkills();
        rogue.Attack();
    }
}