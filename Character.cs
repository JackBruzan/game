using System;

namespace game
{
    public class Character
    {
        string Name { get; set; }
        int Level { get; set; }
        Team team { get; set; }
        Tuple<int, int> Location { get; set; }
        int Experience { get; set; }
        public Stats UnitStats { get; set; }
        public Character(string name, int level, int x, int y)
        {
            Name = name;
            Level = level;
            Location = new Tuple<int, int>(x, y);
            UnitStats = GenerateStats(level);
        }
        public void PrintStats()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Attack Power: {UnitStats.AttackPower}");
            Console.WriteLine($"Magic Power: {UnitStats.MagicPower}");
            Console.WriteLine($"Defense: {UnitStats.Defense}");
            Console.WriteLine($"Magic Defense: {UnitStats.MagicDefense}");
            Console.WriteLine($"Technique: {UnitStats.Technique}");
            Console.WriteLine($"Location: {Location}");
        }
        private Stats GenerateStats(int level)
        {
            int statPoint = 42 + (6 * level);
            int hp = 10;
            statPoint = statPoint - hp;
            int attackPower = 7;
            int magicPower = 6;
            int defense = 7;
            int magicDefense = 6;
            int speed = 5;
            int technique = 7;

            return new Stats(hp,attackPower,magicPower,defense,magicDefense,speed,technique);
        }
        public void Move(){
            Console.WriteLine($"{Name} moved.");
        }
    }
}
