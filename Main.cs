class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Hero");
            Monster monster1 = new Monster("Goblin");
            Monster monster2 = new Monster("Dragon");

            Console.WriteLine("Battle Start!\n");

            while (player.IsAlive() && (monster1.IsAlive() || monster2.IsAlive()))
            {
                Console.WriteLine(player.Name + " HP: " + player.Health);
                Console.WriteLine(monster1.Name + " HP: " + monster1.Health);
                Console.WriteLine(monster2.Name + " HP: " + monster2.Health);
                Console.WriteLine();

                if (monster1.IsAlive())
                    player.AttackTarget(monster1);
                else if (monster2.IsAlive())
                    player.AttackTarget(monster2);

                if (monster1.IsAlive())
                    monster1.AttackTarget(player);

                if (monster2.IsAlive())
                    monster2.AttackTarget(player);

                Console.WriteLine("---------------------");
            }

            if (player.IsAlive())
                Console.WriteLine("Player wins!");
            else
                Console.WriteLine("Monsters win!");

            Console.ReadLine();
        }
    }
