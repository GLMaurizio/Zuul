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
    public int Damage(int amount){
        health -= amount;

        if (health < 0) health = 0;
        
        return health;
    }

    // Health
    public void Heal(int amount){
        health += amount;
    }

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