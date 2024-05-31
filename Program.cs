class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Virtual Pet Simulator! \n");
        Console.WriteLine("Enter a type of pet (e.g., cat, dog, rabbit): \n");
        string petType = Console.ReadLine();
        Console.WriteLine("What is your pet name? \n");
        string petName = Console.ReadLine();

        VirtualPet myPet = new VirtualPet(petName, petType);
        Console.WriteLine($"You have adopted a {myPet.Type} named {myPet.Name}. \n");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Feed the pet");
            Console.WriteLine("2. Play with the pet");
            Console.WriteLine("3. Rest the pet");
            Console.WriteLine("4. Check the pet's status");
            Console.WriteLine("5. Exit");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    myPet.Feed();
                    break;
                case "2":
                    myPet.Play();
                    break;
                case "3":
                    myPet.Rest();
                    break;
                case "4":
                    myPet.CheckStatus();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }
}