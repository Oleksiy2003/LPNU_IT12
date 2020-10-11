using System;

namespace Practic
{
    class Program
    {
        static void Main(string[] args)
        {
            iPhoneSE2 iphone = new iPhoneSE2("iPhone SE 2 ",700);
            iPhoneX iPhoneX = new iPhoneX("iPhone X ",450);
            Product[] products = new Product[] { iphone,iPhoneX};
            Console.WriteLine(0);

            while (true)
            {
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine(products[i].Name + products[i].Price + "\n");
                }
            }
               
                
            
        }
       
    }
   
}
