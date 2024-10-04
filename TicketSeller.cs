using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
internal class TicketSeller
{
    private string name;
    private double price = 10.0;
    private int numOfAdults;
    private int numOfChildren;
    private double childDiscount = 0.50;
    private double amountToPay;
    public void ReadInput()
    {
        bool isValidName = false;
        while (!isValidName)
        {
            Console.Write("What is your name? ");
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

        bool isNumOfAdults = false;
        while (!isNumOfAdults)
        {
            Console.Write("How many adults need tickets? ");
            string numOfAdultsInput = Console.ReadLine();
            if (int.TryParse(numOfAdultsInput, out int parsedAdults))
            {
                this.numOfAdults = parsedAdults; // Set the number of adults if the input is valid
                isNumOfAdults = true;
            }
            else
            {
                Console.WriteLine("Invalid input - please enter numeric values. ");
            }
        }

        bool numOfChildren = false;
        while (!numOfChildren)
        {
            Console.Write("How many children need tickets? ");
            string numOfChildrenInput = Console.ReadLine();
            if (int.TryParse(numOfChildrenInput, out int parsedChildren))
            {
                this.numOfChildren = parsedChildren; // Set the number of adults if the input is valid
                numOfChildren = true;
            }
            else
            {
                Console.WriteLine("Invalid input - please enter numeric values. ");
            }
        }
    }

    public void CalculateAmountToPay()
    {
        double totalAdults = numOfAdults * price;
        double totalKids = numOfChildren * price * (1 - childDiscount);

        amountToPay = totalAdults + totalKids;
    }

    public void DisplayResults()

    {
        CalculateAmountToPay();
        Console.WriteLine($"Total adult tickets: {numOfAdults}");
        Console.WriteLine($"Total child tickets: {numOfChildren}");
        Console.WriteLine($"Total to pay: {amountToPay}");

    }
}

