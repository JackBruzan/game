using System;

namespace game{
    public class Game {
        public bool GameOver {get; set;}
        Character player;
        List<Character> enemies;
        public Game(){
            GameOver = false;
            Console.Write("Enter a character name:");
            string playerName = Console.ReadLine();
            player = new Character(playerName,1,1,1);
            Character enemy = new Character("Enemy 1",1,2,1);
        }
        public void PlayerMove(){
            Console.WriteLine("It is you turn. What would you like to do?");
            Console.WriteLine("List Player Stats: s");
            Console.WriteLine("Move: m");
            Console.WriteLine("Attack: a");
            Console.WriteLine("End Turn: e");

            var input = Console.ReadKey();
            if (input.KeyChar == 's'){
                player.PrintStats();
            }
            else if (input.KeyChar == 'm'){
                player.Move();
            }
            else if (input.KeyChar == 'a'){
                ResolveAttack(player, enemy);
            }
            else if(input.KeyChar == 'e'){
                EndTurn();
            }
            Console.ReadKey();
        }

        public void ResolveAttack(Character attacker, Character defender){
            Console.WriteLine("An attack happened");
        }
        public void EndTurn(){
            Console.WriteLine("You've ended your turn");
        }
    }
}