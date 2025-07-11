﻿using System.Globalization;

namespace PriceTags.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; private set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)}" +
                $" (Manufacture date: {ManufacturedDate.ToString("dd/MM/yyyy")})";
        }
    }
}
