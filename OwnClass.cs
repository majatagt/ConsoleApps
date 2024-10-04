using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//My own class of burgers, that take input and gives a receipt at the end with number of burgers and the date of purchase. 
internal class Burger
{
    public string burgerName;
    public string description = "";
    public int quantity;
    public double price = 15;
    public double totalPrice;
    public DateTime purchaseDate;

    public void PurchaseDate()
    {
        purchaseDate = DateTime.Now;
    }

    public void WriteInput()
    {
        Console.WriteLine("Each of our burgers comes with chips and salad and cost 15£ which burger do you want? ");
        burgerName = Console.ReadLine();
        Console.WriteLine("Excellent choice! A juicy, grilled patty topped with melted cheese, crisp lettuce, fresh tomato, and savory sauces, all nestled between a toasted sesame seed bun.");


        int burgerQuantity;
        string? quantity;
        do
        {
            Console.WriteLine($"How many {burgerName}s do you want? ");

            quantity = Console.ReadLine();

        }
        while (!int.TryParse(quantity, out burgerQuantity));
        this.quantity = burgerQuantity;
    }

    public void CalculateTotal()
    {
        totalPrice = price * quantity;

    }

    public void PrintReceipt()
    {
        CalculateTotal();
        PurchaseDate();
        Console.WriteLine($"Coming right up!    ");
        Console.WriteLine($"A total of {quantity} {burgerName}s with a total price of {totalPrice}");
        Console.WriteLine($"Your order will be delivered to you on {purchaseDate}. Thank you for your custom! ");
    }

}



