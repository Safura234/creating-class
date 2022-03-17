namespace homework
{
    internal class Product
    {
        public int No;
        public string Name;
        public double Price;
        public int Count;
        #region Construction
        public Product(int no, string name, double price, int count)
        {
            No = no;
            Name = name;
            Price = price;
            Count = count;
        }
        #endregion

    }
}
