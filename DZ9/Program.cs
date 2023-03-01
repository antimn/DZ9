namespace DZ9;

public abstract class Program
{
    private static int _attackMagic;
    private static int _attackAxe;
    private static int _attackBow;
    private static int _additionalDamage; //Bonus damage


    public static void Main(string[] args)

    {
        var units = new List<Unit>();
        _attackMagic = 10;
        _additionalDamage = 1;
        units.Add(new Mage { attackWar = "Use MAGIC", attackPower = _attackMagic + _additionalDamage });
        _attackAxe = 12;
        units.Add(new Warrior { attackWar = "Attack with AXE", attackPower = _attackAxe });
        _attackBow = 15;
        units.Add(new Hunter { attackWar = "Attack with BOW", attackPower = _attackBow });

        foreach (Unit unit in units)
        {
            Console.WriteLine($"Hero: {unit.attackWar}, Damage {unit.attackPower}");
            unit.Attack();
        }

        Rogue rogue = new Rogue();
        Rogue.UseSkills();

        //upCast
        var mage = new Mage();
        Unit controlledAttack = null;
        controlledAttack = mage;
        controlledAttack.attackWar = "Mage saw effect of Vanish and received damage";
        controlledAttack.attackPower = 20;
        Console.WriteLine($"Hero: {mage.attackWar}, Damage from ambush spell {mage.attackPower}");
        Mage.Notice();
        controlledAttack.OutFromBattle();
    }
}