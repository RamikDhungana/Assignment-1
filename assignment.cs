using System;

class RoseBlanches
{
    static void Main()
    {
        Console.Write("How much did you receive money ($)? ");
        
        double totalMoney = Convert.ToDouble(Console.ReadLine());
        
        double booksAndSupplies = 0.75 * totalMoney;
        
        double remainingMoney = totalMoney - booksAndSupplies;
        
        int coffees = (int)(remainingMoney / 2);
        
        int flashComputerNumbers = (int)(remainingMoney / 4);
        
        int subwayTickets = (int)(remainingMoney / 3);

        double whiteRoses = remainingMoney - (coffees * 2 + flashComputerNumbers * 4 + subwayTickets * 3);
        Console.WriteLine($"Book and Supplies: {booksAndSupplies:C}");
        Console.WriteLine($"You can then buy:");
        Console.WriteLine($"{coffees} coffees");
        Console.WriteLine($"{flashComputerNumbers} Flash Computer Numbers");
        Console.WriteLine($"{subwayTickets} subway Tickets");
        Console.WriteLine($"and you will have {whiteRoses:C} for the white roses.");
    }
}

