using System;

using ItemHome;
using CartHome;


public class Program
{
    static void Main()
    {
        //Set up for the program
        int[] idList = { 0, 1, 2, 3, 4, 5 };
        float[] priceList = { 0.00f, 3.50f, 60.00f, 0.99f, 100.00f, 0.01f };
        string[] nameList = { "", "Snack", "Video Game", "Arizona Tea", "Fancy Hat", "Penny" };
        Cart shopping = new Cart();
        bool stop = false;
        int selectedItem;
        int selectedAmount;
        //User input to control the program
        do
        {
            Console.WriteLine("Would you like to... (please type the related number) \n 1. Add an item to the Cart \n 2. Delete an Item from the Cart \n 3. View the Cart \n 4. View the Item List \n 5. View Cart Total \n 6. Quit");
            int userIn = int.Parse(Console.ReadLine());
            if (userIn == 1)
            {
                // lists all items in array
                for (int i = 1; i < nameList.Length; i++)
                {
                    Console.WriteLine(idList[i] + ":" + nameList[i]);
                }

                Console.WriteLine("Select one of the options with the related number.");
                selectedItem = int.Parse(Console.ReadLine());
                Console.WriteLine("How many of the " + nameList[selectedItem] + " do you want?");
                selectedAmount = int.Parse(Console.ReadLine());
                shopping.addItem(selectedAmount, selectedItem, nameList[selectedItem], priceList[selectedItem]);

            }
            else if (userIn == 2)
            {
                shopping.showList();
                Console.WriteLine("Select one of the options by ID number.");
                selectedItem = int.Parse(Console.ReadLine());
                shopping.deleteItem(selectedItem, priceList[selectedItem]);

            }
            else if (userIn == 3)
            {
                shopping.showList();
            }
            else if (userIn == 4)
            {
                // Shows all items in the array
                for (int i = 1; i < nameList.GetLength(0); i++)
                {
                    Console.WriteLine(idList[i] + ":" + nameList[i]);
                }
            }
            else if (userIn == 5)
            {
                Console.WriteLine(shopping.getTotal());
            }
            else if (userIn == 6)
            {
                stop = true;
            }
            else
            {
                Console.WriteLine("Invalid Selection. Try the number on it's own.");
            }
            Console.WriteLine("");
        } while (!stop);
        Console.WriteLine("Thanks for using this program.");
        Console.ReadLine();
    }
}

