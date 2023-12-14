namespace supermarket
{
    internal class Product
    {
        public Product(string name, int prise)
        {
            Name = name;

            Prise = prise;
        }

        public string Name { get; private set; }
        public int Prise { get; private set; }
    }
}