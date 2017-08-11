namespace ItemHome
{

    public class Item
    {

        protected int id;
        protected int amount;
        protected string name;
        public Item next;

        public Item()
        {
            amount = 0;
            name = "";
            id = 0;
            next = null;
        }

        public Item(int idIn, int amountIn, string nameIn)
        {
            amount = amountIn;
            name = nameIn;
            id = idIn;
            next = null;
        }

        public int getAmount()
        {
            return amount;
        }

        public string getName()
        {
            return name;
        }

        public int getId()
        {
            return id;
        }

        public void setAmount(int amountIn)
        {
            amount = amountIn;
        }

        public void setName(string nameIn)
        {
            name = nameIn;
        }


    }
}