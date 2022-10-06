namespace shopping_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
               
            Dictionary<string,double> shoppingList = new Dictionary<string,double> { };           
             shoppingList.Add("eggs are ", 8.99);
                shoppingList.Add("ham is ", 12.99);
                shoppingList.Add("cheese is ", 2.99);
            shoppingList.Add("steak is ", 14.99);
                shoppingList.Add("milky ways are ", 1.99);
                shoppingList.Add("Gfuel is ", 35.95);
                shoppingList.Add("peppers are ", 3.49);
                shoppingList.Add("lemons are ", 2.49);
            Console.WriteLine("Welcome to the 8-12, the items we have are:");
           foreach (KeyValuePair<string,double> products in shoppingList)
            {
                Console.WriteLine(products.Key + " " + products.Value);
            }
                List<string> shoppingList2 = new List<string>();
            bool list = true;
            while (list == true) 
            {

                Console.WriteLine("which products would you like to add?:");
                string input = Console.ReadLine().ToLower().Trim();
                if (input == "eggs" || input == "ham" || input == "cheese" || input == "steak" || input == "Milky ways" || input == "Gfuel" || input == "peppers" || input == "lemons") ;



            }
        
        
        
        }


    }
}