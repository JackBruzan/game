using System;

namespace game
{
    public class Stats
    {
        public int HP { get; set; }
        public int Speed { get; set; }
        public int AttackPower { get; set; }
        public int MagicPower { get; set; }
        public int Defense { get; set; }
        public int MagicDefense { get; set; }
        public int Technique { get; set; }
        public Stats(int hp, int attackPower, int magicPower, int defense, int magicDefense, int speed, int technique){
            HP = hp;
            AttackPower = attackPower;
            MagicPower = magicPower;
            Defense = defense;
            MagicDefense = magicDefense;
            Speed = speed;
            Technique = technique;
        }
    }
}
