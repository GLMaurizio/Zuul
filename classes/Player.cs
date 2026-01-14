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
    public void Damage(int amount) {}

    // Health
    public void Heal(int amount) {}

    public bool IsAlive()
    {

    if (health != 0) {
        Console.WriteLine("Alive");
        return true;}
    
    else {
        Console.WriteLine("Dead");
        return false;}
    }

}