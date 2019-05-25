using System;
using System.Collections.Generic;
using System.Text;

namespace Herança_Classe_e_Metodos_selados.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct (string name, double price, DateTime date) : base (name, price)
        {
            ManufactureDate = date;
        }

        public override string ToString()
        {
            return Name
                + " (used) $ "
                + Price
                + " (Manufacture date: "
                + ManufactureDate;
        }
    }
}
