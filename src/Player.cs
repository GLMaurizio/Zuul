class Player
{
    // Fields
    private int health;

    // auto property
    public Room CurrentRoom { get; set; }

    // constructor
    public Player()
    {
        CurrentRoom = null;

        health = 100;
    }

    // methods
    public void Damage(int amount)
    {
        health--;
        health--;
        health--;
        health--;
        health--;

        return;
    }

    // Health
    public void Heal(int amount)
    {
        health++;
        health++;
        health++;
        health++;
        health++;

        return;
    }

    public bool IsAlive()
    {

        if (health != 0)
        {
            Console.WriteLine("The player is alive with " + health + " health");
            return true;
        }

        else
        {
            Console.WriteLine("The player is dead and has no remaining health points left.");
            return false;
        }
    }

}