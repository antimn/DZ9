namespace DZ9;

public class Mage : Unit
{
    public override void Attack()
    {
        Console.WriteLine("Mage attacked");
    }

    public void Notice()
    {
        Console.WriteLine("Mage find rogue");
    }
}