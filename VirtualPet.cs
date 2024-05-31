public class VirtualPet
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Hunger { get; set; } = 5;  // Mid value on a scale from 1 to 10
    public int Happiness { get; set; } = 5;
    public int Health { get; set; } = 5;

    public VirtualPet(string name, string type)
    {
        Name = name;
        Type = type;
    }

    // This method is called by the Feed, Play, and Rest methods and its just used to simulate the passing of time    
    public void PassingOfTime() {
        Hunger = Math.Max(10, Hunger + 2);
        Happiness = Math.Max(1, Happiness - 1);
    }

    public void Feed()
    {
        PassingOfTime(); 
        Hunger = Math.Max(1, Hunger - 2);
        Health = Math.Min(10, Health + 1);
        Console.WriteLine($"{Name} has been fed. Hunger decreased and health increased slightly. \n");
    }

    public void Play()
    {
        PassingOfTime();
        if (Hunger >= 8) 
        {
            Console.WriteLine($"{Name} is too hungry to play. Feed your pet first! \n");
            return;
        }
        if (Happiness <= 2) 
        {
            Console.WriteLine($"{Name} is too sad to play. Rest your pet first! \n");
            return;
        }
        Happiness = Math.Min(10, Happiness + 2);
        Hunger = Math.Min(10, Hunger + 1);
        Console.WriteLine($"{Name} is playing. Happiness increased and hunger increased slightly. \n");
        Console.WriteLine();
    }

    public void Rest()
    {
        PassingOfTime();
        Health = Math.Min(10, Health + 3);
        Happiness = Math.Max(1, Happiness - 1);
        Console.WriteLine($"{Name} is resting. Health improved and happiness decreased slightly. \n");
    }

    public void CheckStatus()
    {
        if (Hunger >= 8) Console.WriteLine($"{Name} is very hungry! \n");
        if (Happiness <= 2) Console.WriteLine($"{Name} is very sad! \n");
        if (Health <= 2) Console.WriteLine($"{Name} is very unhealthy! \n");
    }
}