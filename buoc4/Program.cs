using System;
using  System.Text;
namespace buoc4
{
    public class Product
    {
        private string name="";
        private double price;
        public string Name
        {
            get{return name;}
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    value=value.Trim();
                    name=char.ToUpper(value[0])+value.Substring(1);
                }
                else
                {
                    name=value;
                }
            }
        }
        public double Price
        {
            get{return price;}
            set
            {
                if(value<0)
                {
                    price=0;
                    Console.WriteLine("Gia khong hop le,da dat ve 0");
                }
                else
                {
                    price=value;
                }
            }
        }
        public void ShowProduct()
        {
            Console.WriteLine($"San Pham:{Name}---Gia:{Price}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Product sp=new Product();
            sp.Name= "Truyen Tranh";
            sp.Price= -100;
            sp.ShowProduct();
            sp.Name= "Ban phim co";
            sp.Price=500000;
            sp.ShowProduct();
            Console.ReadLine();
        }
    }
}