using System.Globalization;

namespace Herança_Classe_e_Metodos_selados.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string ToString()
        {
            return base.ToString()
                + $" (Custom Fee: $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + ") ";
        }
    }
}
