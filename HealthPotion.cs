// LABEL: Inheritance & Polymorphism
public class HealthPotion : Item
{
    private int healAmount = 20;

    public HealthPotion() : base("Health Potion", "Restores 20 HP.") { }

    public override void Apply(Character target)
    {
        target.Health += healAmount;
        
        Console.WriteLine(Name + " used! " + target.Name + " recovered " + healAmount + " HP.");
    }
}