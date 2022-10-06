using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_2
{
    public class Tovar{
        string name;
        string specification;
        string description;
        double price;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Specification
        {
            get => specification;
            set => specification = value;
        }
        public string Description
        {
            get => description;
            set => description = value;
        }
        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new Exception("Цена не может быть меньше нуля");
                price = value;
            }
        }
        public Tovar(){ }

        public Tovar(Product p) {
            name = p.name;
            specification = p.specification;
            description = p.specification;
            price = p.price;
        }


        public override string ToString()
        {
            return $"Товар: {Name} Цена: {Price}";
        }

        public override bool Equals(object obj)
        {
            return obj is Tovar product &&
                   Name == product.Name &&
                   Specification == product.Specification &&
                   Description == product.Description &&
                   Price == product.Price;
        }

        public override int GetHashCode()
        {
            var hashCode = 1766939827;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Specification);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }

        public static bool operator == (Tovar p1, Tovar p2)
        {
            if (p1.Name == p2.Name && p1.Specification == p2.Specification &&
                p1.Description == p2.Description && p1.Price == p2.Price)
                return true;
            else
                return false;
        }
        public static bool operator != (Tovar p1, Tovar p2)
        {
            if (p1 == p2)
                return false;
            else
                return true;
        }
        public static double operator + (double d, Tovar p)
        {
            return d + p.Price;
        }

        public static double operator -(double d, Tovar p)
        {
            return d - p.Price;
        }
    }
    public class Product : Tovar
    {
        public override string ToString()
        {
            return $"Товар: {Name}";
        }
    }
}
