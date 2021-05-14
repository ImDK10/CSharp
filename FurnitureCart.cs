using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppItem
{
    class Shopping
    {
        public void Items()
        {

            Console.WriteLine("Welcome to Dilip Furnitures ");
            Console.WriteLine("*****************************************");
            Console.WriteLine("1.Table\n2.Wardrobe\n3.Chair\n4.Exit");
            Console.WriteLine("*****************************************");
        }
    }
    class Table : Shopping
    {
        public string material = "Teak Wood";
        public string model = "Round shaped (Dining)";
        public string color = "Brown";
        public int height = 76;
        public int price = 25000;
    }
    class wardrobe : Shopping
    {
        public string material = "Engineering Wood";
        public string model = "Modren";
        public string color = "Brown";
        public int shelfs = 8;
        public int price = 35000;
    }
    class chair : Shopping
    {
        public string material = "Plastic";
        public string model = "Cello";
        public string color = "Black";
        public int price = 1500;
    }
    class exit
    {
        public void end()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("******************************************************");
            Console.WriteLine("You ordered nothing from us");
            Console.WriteLine("Thank You for visiting");
            Console.WriteLine("******************************************************");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Table obj = new Table();
            wardrobe obj1 = new wardrobe();
            chair obj2 = new chair();
            exit obj3 = new exit();

            obj.Items(); //obj1 , obj2 will also work (Inheritance)//

            Console.WriteLine("-------------------------------------");
            Console.Write("Enter the item you want to purchase: ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch(x)
            {
                case 1 :
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("You ordered Table");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Material: "+ obj.material);
                        Console.WriteLine("Model:    "+ obj.model);
                        Console.WriteLine("Color:    "+ obj.color);
                        Console.WriteLine("Height:   "+ obj.height + "cms");
                        Console.WriteLine("Cost:     "+ obj.price + "/-");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Thank you for choosing our product!");
                        break;
                    }
                case 2 :
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("You ordered Wardrobe");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Material: "+obj1.material);
                        Console.WriteLine("Model:    "+obj1.model);
                        Console.WriteLine("Color:    "+obj1.color);
                        Console.WriteLine("Shelfs:   "+obj1.shelfs);
                        Console.WriteLine("Cost:     "+obj1.price + "/-");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Thank you for choosing our product!");
                        break;
                    }
                case 3 :
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("-------------------------------------"); 
                        Console.WriteLine("You ordered Chair");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Material: "+obj2.material);
                        Console.WriteLine("Model:    "+obj2.model);
                        Console.WriteLine("Color:    "+obj2.color);
                        Console.WriteLine("Cost:     "+obj2.price + "/-");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Thank you for choosing our product!");
                        break;
                    }
                case 4 :
                    {
                        obj3.end();
                        break;
                    }

                    
            }
            Console.ReadLine();
            
        }
        
    
    }
        
    
}
