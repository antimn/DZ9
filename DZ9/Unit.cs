namespace DZ9;

public abstract class Unit

{

    public string atackVar { get; set; }
    public int atackPower { get; set; }

    public virtual void Attack()
    {
        Console.WriteLine("Attack");
    }
}