// LABEL: Collections & Encapsulation
using System;
using System.Collections.Generic;

public class Inventory
{
    private List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);
        Console.WriteLine(item.Name + " added to inventory.");
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }

    public List<Item> GetItems()
    {
        return items;
    }

    public void DisplayInventory()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        Console.WriteLine("\n=== Inventory ===");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + items[i].Name + " - " + items[i].Description);
        }
        Console.WriteLine("=================\n");
    }

    public bool HasItems()
    {
        return items.Count > 0;
    }
}