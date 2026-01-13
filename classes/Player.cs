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
    public void Damage() {}

    // Health
    public void Heal() {}

    public void IsAlive() {}

}
