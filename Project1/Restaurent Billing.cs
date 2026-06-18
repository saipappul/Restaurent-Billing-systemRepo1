using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Restaurent_Billing
    {
       
        // To store Final Ordered items
        Dictionary<string, int> FinalBillItems = new Dictionary<string, int>();
        Dictionary<int, (string itemname, int price)> Menu = new Dictionary<int, (string, int)>();
        public Restaurent_Billing()
        {
            Console.WriteLine("test");
            Console.WriteLine("test"); Console.WriteLine("test"); Console.WriteLine("test"); Console.WriteLine("test"); Console.WriteLine("test"); Console.WriteLine("test");
            Console.WriteLine("test");
            Console.WriteLine("test");
            Console.WriteLine("test");
            Menu.Add(1, ("Poori", 10));
            Menu.Add(2, ("Idly", 20));
            Menu.Add(3, ("Uthappa", 30));
            Menu.Add(4, ("Bonda", 40));

            Console.WriteLine("------------> Select Your Favourites <-----------------");
            Console.WriteLine();
            Console.Write("{0,-8} {1,-10} {2,-10}", "Itemid", "Itemname", "Price");
            Console.WriteLine();

            foreach (var item in Menu)
            {

                Console.WriteLine("{0,-8} {1,-10} {2,-10}", item.Key, item.Value.itemname, item.Value.price);
            }
            Console.WriteLine();

        }
        // For displaying Menuitems
        public void Menuselection()
        {
           

            // Item selection
            Console.WriteLine("Enter itemnumber  u want to select");
            int selectitem = 0;

            selectitem = int.Parse(Console.ReadLine());

            
            Console.WriteLine();
            Console.WriteLine("Your Selected itemname is {0} and  Price is {1}", Menu[selectitem].itemname, Menu[selectitem].price);

            // Inserting final amount selected
            FinalBillItems.Add(Menu[selectitem].itemname, Menu[selectitem].price);

            Console.WriteLine();
            Console.WriteLine("You want another Item(y/n)");
            string Yesorno = Console.ReadLine();
            Console.WriteLine();

            // If customer want select more then call menuselection method again
            if (Yesorno == "y")
            {
                Menuselection();
            }
            else  // Print bill
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for your Order and Your total Items are :");

                Console.WriteLine("--------------------------------");
                int Totalamount = 0;

                foreach (var item in FinalBillItems)
                {
                    Console.WriteLine("{0,-10} {1}",
                        item.Key,
                        item.Value);


                    Totalamount = Totalamount + item.Value;


                }

                Console.WriteLine("Your FinalBill amount is {0}", Totalamount);
                Console.WriteLine("--------------------------------");


                Console.WriteLine("You want cancel any item");
                string itemname = Console.ReadLine();

                Console.WriteLine("Your Final Orders and Your total Items are :");

                FinalBillItems.Remove(itemname);
                Totalamount = 0;
                foreach (var finalitem in FinalBillItems)
                {
                    Console.WriteLine("{0,-10} {1}",
                        finalitem.Key,
                        finalitem.Value);


                    Totalamount = Totalamount + finalitem.Value;


                }

                Console.WriteLine("Bill {0}", Totalamount);
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
