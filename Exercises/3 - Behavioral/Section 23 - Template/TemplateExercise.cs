namespace Exercises._3___Behavioral.Section_23___Template
{
    /*
    
    Imagine a typical collectible card game which has cards representing creatures. Each creature has two values: Attack and Health. Creatures can fight each other, dealing their Attack damage, thereby reducing their opponent's health.

    The class CardGame implements the logic for two creatures fighting one another. However, the exact mechanics of how damage is dealt is different:

        - TemporaryCardDamage: In some games (e.g., Magic: the Gathering), unless the creature has been killed, its health returns to the original value at the end of combat.
        - PermanentCardDamage: In other games (e.g., Hearthstone), health damage persists.
    You are asked to implement classes TemporaryCardDamageGame and PermanentCardDamageGame that would allow us to simulate combat between creatures.

    Some examples:

        - With temporary damage, creatures 1/2 and 1/3 can never kill one another. With permanent damage, second creature will win after 2 rounds of combat.
        - With either temporary or permanent damage, two 2/2 creatures kill one another.
    */

    public class Creature
    {
        public int Attack, Health;

        public Creature(int attack, int health)
        {
            Attack = attack;
            Health = health;
        }
    }

    public abstract class CardGame
    {
        public Creature[] Creatures;

        public CardGame(Creature[] creatures)
        {
            Creatures = creatures;
        }

        // returns -1 if no clear winner (both alive or both dead)
        public int Combat(int creature1, int creature2)
        {
            Creature first  = Creatures[creature1];
            Creature second = Creatures[creature2];

            if(first.Health <= 0)
            {
                return creature2;
            }

            else if(second.Health <= 0)
            {
                return creature1;
            }

            Hit(first, second);
            Hit(second, first);

            bool firstAlive     = first.Health > 0;
            bool secondAlive    = second.Health > 0;
            
            if (firstAlive == secondAlive)
            { 
                return -1; 
            }
            
            return firstAlive ? creature1 : creature2;
        }

        // attacker hits other creature
        protected abstract void Hit(Creature attacker, Creature other);
    }

    public class TemporaryCardDamageGame : CardGame
    {
        public TemporaryCardDamageGame(Creature[] creatures) : base(creatures)
        {
        }

        protected override void Hit(Creature attacker, Creature other)
        {
            int originalHealth = other.Health;
            other.Health -= attacker.Attack;

            if (other.Health > 0)
            {
                other.Health = originalHealth;
            }
        }
    }

    public class PermanentCardDamage : CardGame
    {
        public PermanentCardDamage(Creature[] creatures) : base(creatures)
        {
        }

        // todo
        protected override void Hit(Creature attacker, Creature other)
        {
            other.Health -= attacker.Attack;
        }
    }
}
