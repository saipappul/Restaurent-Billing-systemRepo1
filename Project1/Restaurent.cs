using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Restaurent
    {
        public static void RestaurentBill()
        {
            int Totalamount = 0;
            string response = "";
            int price=0;
            int Nofoitems = 0;
            string Name = "";
            Dictionary<string, (string Name, int price)> selecteditems = new Dictionary<string, (string, int)>();
            Dictionary<int,(string name, int price)> di = new Dictionary<int,(string, int)>();

            di.Add(1,("Idly",30));
            di.Add(2, ("Bonda", 30));
            di.Add(3, ("Dosa", 40));
            di.Add(4, ("Poori", 40));
            Console.WriteLine("ItemNumber\tItemName\tPrice");
            foreach (var i in di)
            {
                Console.WriteLine($"{i.Key}\t\t{i.Value.name}\t\t{i.Value.price}");
            }

            do
            {

                Nofoitems = Nofoitems+1;
                Console.WriteLine("Enter Item Number");
                string item = Console.ReadLine();
                
                if (item == "1")
                {
                    price = 30;
                    Name = "Idly";
                }
                else if (item == "2")
                {
                    price = 30;
                    Name = "Bonda";
                }
                else if (item == "3")
                {
                    price = 40;
                    Name = "Dosa";
                }
                else if (item == "4")
                {
                    price = 40;
                    Name = "Poori";
                }
               
                Totalamount= Totalamount + price;

                

                selecteditems.Add(item, (Name, price));

                 Console.WriteLine("You want to Add Another Item y/n");
                 response = Console.ReadLine();

                if (response == "n")
                { 
                    foreach (var data in selecteditems)
                    {
                        Console.WriteLine(data);
                    }

                }
            } while (response == "y");
            Console.WriteLine("Your Total selected Items are " + Nofoitems+" And Total bill is " + Totalamount);
        }

    }
}
