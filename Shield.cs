// LABEL: Inheritance & Polymorphism
public class Shield : Item
{
    private int defenseBonus = 3;

    public Shield() : base("Wooden Shield", "Boosts defense stat.") { }

    public override void Apply(Character target)
    {
        // modify the 'Defense' property in the Character class
        target.Defense += defenseBonus;
        Console.WriteLine(target.Name + " equipped " + Name + ". Defense increased by " + defenseBonus + "!");
    }
}