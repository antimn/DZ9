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
        rogue.UseSkills();

        //upCast
        var mage = new Mage();
        Unit controlledAttack = null;
        controlledAttack = mage;
        mage.Attack();
        controlledAttack.OutFromBattle();
        
        
    }
    
}