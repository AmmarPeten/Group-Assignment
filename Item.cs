// LABEL: Abstract Class & Encapsulation
public abstract class Item
{
    private string name;
    private string description;

    // Encapsulation: Using properties to access private fields 
    public string Name { get { return name; } set { name = value; } }
    public string Description { get { return description; } set { description = value; } }

    public Item(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    // This method is called by Ammar's UseItemAction.cs
    public abstract void Apply(Character target);
}