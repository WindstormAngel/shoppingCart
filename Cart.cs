namespace CartHome
{

    using System;
    using ItemHome;

    public class Cart
    {
        private Item head;
        private float total;

        public Cart()
        {
            head = new Item();
            total = 0.00f;
        }

        public void addItem(int numberIn, int idIn, string nameIn, float priceIn)
        {
            // search for the id in the list
            Item itemCheck = head;
            while ((itemCheck != null) && (itemCheck.getId() != idIn))
            {
                itemCheck = itemCheck.next;
            }

            // Item doesnt exist, make new item and put in front
            if (itemCheck == null)
            {
                Item addOn = new Item(idIn, numberIn, nameIn);
                addOn.next = head.next;
                head.next = addOn;
                // print out that it was added
                Console.WriteLine(numberIn + " of " + nameIn + " was added.");
            }

            // Item exists, add more to it
            else
            {
                itemCheck.setAmount(itemCheck.getAmount() + numberIn);
                // print out that it was updated
                Console.WriteLine(numberIn + " of " + nameIn + " was added.");
            }

            updateTotalUp(numberIn, priceIn);
            //If gotten here with no console out, it died
        }

        public void deleteItem(int idIn, float priceIn)
        {
            // search for the id in the list
            Item previousItem = null;
            Item itemCheck = head;
            while ((itemCheck != null) && (itemCheck.getId() != idIn))
            {
                previousItem = itemCheck;
                itemCheck = itemCheck.next;
            }

            // Item found, previous skips it and now points to the next item after it
            if (itemCheck != null)
            {
                Console.WriteLine("All of the " + itemCheck.getName() + " was removed.");
                updateTotalDown(itemCheck.getAmount(), priceIn);
                previousItem.next = itemCheck.next;
            }
            else
            {
                // print that it didnt exist.
                Console.WriteLine("The item did not exist.");
            }
        }

        public void showList()
        {
            // creates a table of items with their names, amounts, and ids
            Item itemCheck = head;
            Console.WriteLine("ID : Item : Amount");
            while (itemCheck.next != null)
            {
                itemCheck = itemCheck.next;
                Console.WriteLine(itemCheck.getId() + " : " + itemCheck.getName() + " : " + itemCheck.getAmount());
            }
        }

        public void updateTotalUp(int numberIn, float priceIn)
        {
            // updates total due to more in cart
            total += (numberIn * priceIn);
        }

        public void updateTotalDown(int numberIn, float priceIn)
        {
            // updates total due to less in cart
            total -= (numberIn * priceIn);
        }

        public float getTotal()
        {
            return total;
        }
    }
}
