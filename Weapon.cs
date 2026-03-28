// LABEL: Inheritance & Polymorphism
public class Weapon : Item
{
    private int attackBonus = 5;

    public Weapon() : base("Iron Sword", "Increases base attack damage.") { }

    public override void Apply(Character target)
    {
        // modify the 'Attack' property in the Character class
        target.Attack += attackBonus; 
        Console.WriteLine(target.Name + " equipped " + Name + ". Attack increased by " + attackBonus + "!");
    }
}