 public class Character
    {
        public string Name;
        public int Health;
        public int Attack;

        public Character(string name, int health, int attack)
        {
            Name = name;
            Health = health;
            Attack = attack;
        }

        public void AttackTarget(Character target)
        {
            target.Health -= Attack;
            Console.WriteLine(Name + " hits " + target.Name + " for " + Attack + " damage.");
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
