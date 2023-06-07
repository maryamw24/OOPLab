using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    class Product
    {
        private string Name;
        private int Price;
        private string Category;
        private int quantity;
        private int min_quantity;
        private float tax;
        public Product(string Name, int Price, string Category, int quantity, int min_quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Category = Category;
            this.quantity = quantity;
            this.min_quantity = min_quantity;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetCategory()
        {
            return Category;
        }
        public int GetPrice()
        {
            return Price;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public int GetMin_Quantity()
        {
            return min_quantity;
        }
        public float GetTax()
        {
            return tax;
        }
        public void SetTax(float tax)

        {
            this.tax = tax;
        }
        public void viewProducts()
        {
            Console.WriteLine(GetName().PadRight(20) + GetCategory() + GetPrice().ToString().PadRight(20) + GetQuantity().ToString().PadRight(20) + GetMin_Quantity().ToString().PadRight(20));
        }
        public float taxCalculator()
        {
            float tax = 0.0F;
            if (GetCategory() == "grocery" || GetCategory() == "Grocery")
            {
                tax = GetPrice() * 0.1F;
            }
            else if (GetCategory() == "Fruit" || GetCategory() == "fruit")
            {
                tax = GetPrice() * 0.05F;
            }
            return tax;
        }
    }
}
