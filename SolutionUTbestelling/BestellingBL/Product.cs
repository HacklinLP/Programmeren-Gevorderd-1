namespace BestellingBL
{
    public class Product
    {
        public Product(int id, string naam, double prijs)
        {
            Id = id;
            Naam = naam;
            Prijs = prijs;
        }

        public int Id { get; set; }

        public string Naam { get; set; }

        public double Prijs { get; set; }
    }
}
