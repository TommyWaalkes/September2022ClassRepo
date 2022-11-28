
using CompistionExample;
using CompistionExample.Attacks;
using CompistionExample.Defenses;

Character one = new Character(new RandomAttack(1,5), new DamageReduction(2), 10);

Character opponent = new Character(new RandomAttack(1, 3), new DodgeDefense(30), 10);
Fight(one, opponent);

 static void Fight(Character player, Character opponent)
{
    //While both characters are alive keep fighting 
    while (player.IsAlive && opponent.IsAlive)
    {
        player.Attack(opponent);
        opponent.Attack(player);

        Console.WriteLine($"Player has {player.HP} HP left");
        Console.WriteLine($"Opponent has {opponent.HP} HP left");
    }
}