namespace DZ9;

public abstract class Unit

{
    public string attackWar { get; set; }
    public int attackPower { get; set; }

    public virtual void Attack()
    {
        Console.WriteLine("Attack");
    }

    public void OutFromBattle()
    {
        Console.WriteLine("Mage ran away");
    }
}