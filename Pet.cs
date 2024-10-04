public class Pet
{
    // Properties for the Pet class
    private int age
    {
        get;
        set;
    }
    private bool isFemale
    {
        get;
        set;
    }
    private string name
    {
        get;
        set;
    }
    // Method to read input from the user
    public void ReadAndSavePetData()
    {
        // Input and validation for age
        bool isValidAge = false;
        while (!isValidAge)
        {
            Console.Write("Enter the age of your pet: ");
            string ageInput = Console.ReadLine();
            if (int.TryParse(ageInput, out int parsedAge))
            {
                this.age = parsedAge; // Set the age if the input is valid
                isValidAge = true;
            }
            else
            {
                Console.WriteLine("Invalid input - please enter a number. ");
            }
        }
        // Input and validation for isFemale (true/false)
        bool isFemale = false;
        while (!isFemale)
        {
            Console.Write("Is your pet female? (true/false): ");
            string isFemaleInput = Console.ReadLine();
            if (bool.TryParse(isFemaleInput, out bool parsedIsFemale))
            {
                this.isFemale = isFemale; // Set the gender if the input is valid
                isFemale = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
            }

        }

        // Input and validation for name (true/false)
        bool isValidName = false;
        while (!isValidName)
        {
            Console.Write("What is your pets name? ");
            string nameInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(nameInput))
            {
                this.name = nameInput;
                isValidName = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid name");

            }
        }

        static extern void DisplayPetInfo();
        {
            Console.WriteLine($"Your {(isFemale? "female" : "male")} dog named {name}, aged {age} have been added to our records!");
        }
    }
}