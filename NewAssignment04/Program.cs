namespace NewAssignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 04 solution");
            Console.WriteLine("==============A01===============");
            #region Task01
            /*Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price (index 1).*/
            double[] price = { 25.5, 40.0, 33.75 };
            Console.WriteLine(price[1]);
            Console.WriteLine("\n");
            #endregion
            #region Task02
            Console.WriteLine("==============A02===============");
            /*Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0. .*/
            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine(shelfCopies[1, 0]);
            Console.WriteLine("\n");
            #endregion
            #region Task03
            Console.WriteLine("==============A03===============");
            /*Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!". Call it from Main..*/
            
            PrintWelcomeMessage();

            Console.WriteLine("\n");
            #endregion
            #region Task04
            Console.WriteLine("==============A04===============");
            /*Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".*/
           
            PrintBookTitle("Clean Code");

            Console.WriteLine("\n");
            #endregion
            #region Task05
            Console.WriteLine("==============A05===============");
            /*Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?.*/
            int pages05 = 400;
            
            addBonusPages(pages05);
            Console.WriteLine(pages05);
            Console.WriteLine("\n");
            #endregion
            #region Task06
            Console.WriteLine("==============A06===============");
            /*Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to see, and why?.*/
            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            Console.WriteLine(prices[0]);
            Console.WriteLine("\n");
            #endregion
            #region Task07
            Console.WriteLine("==============A07===============");
            /*Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5? .*/
            int pages07 = 400;
            addBonusPagesByRef(ref pages07);
            Console.WriteLine(pages07);

            Console.WriteLine("\n");
            #endregion
            #region Task08
            Console.WriteLine("==============A08===============");
            /*Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length afterward. .*/
            ReplaceArray(ref prices);
            //double[] prices = { 25.5, 40.0 };
            Console.WriteLine(prices.Length);



            Console.WriteLine("\n");
            #endregion
            #region Task09
            Console.WriteLine("==============A09===============");
            /*Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it and print the price if found.*/

            string title09 = "Clean Code";

            bool found = TryGetPrice(title09, out double price09);

            if (found)
            {
                Console.WriteLine($"Price: {price09}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
            Console.WriteLine("\n");
            #endregion
            #region Task10
            /*Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call it once with only a title, and once passing both a title and pages*/
            Console.WriteLine("==============A10===============");
            PrintBookInfo("Clean Code");
            PrintBookInfo("C# in Depth", 450);

            Console.WriteLine("\n");
            #endregion
            #region Task11
            /*Using the PrintBookInfo method from the question above, call it by naming the parameters, passing pages before title.*/
            Console.WriteLine("==============A11===============");

            PrintBookInfoNamed(pages: 450, title: "C# in Depth");

            Console.WriteLine("\n");
            #endregion
            #region Task12
            /*Write a method PrintAllTitles(params string[] titles) that prints each title on its own line. Call it with three book titles.*/
            Console.WriteLine("==============A12===============");

            PrintAllTitles("Clean Code", "C# in Depth", "The Pragmatic Programmer");

            Console.WriteLine("\n");
            #endregion

            // Assignment Methods :

            // Task 3: PrintWelcomeMessage method
            static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }
            // Task 4: PrintBookTitle method
            static void PrintBookTitle(string title04)
            {
                Console.WriteLine("Book title: " + title04);
            }
            // Task 5: AddBonusPages method
            static void addBonusPages(int pages05)
            {
                pages05 = pages05 + 50;
            }
            // Task 6: ApplyDiscount method
            static void ApplyDiscount(double[] prices)
            {
                prices[0] = prices[0] - 5;
            }
            // Task 7: AddBonusPagesByRef method
            static void addBonusPagesByRef(ref int pages)
            {
                pages= pages + 50;
            }
            // Task 8: ReplaceArray method
            static void ReplaceArray(ref double[] prices)
            {
                prices = new double[] { 10.0, 12.5, 15.0 };
            }
            // Task 9: TryGetPrice method
            static bool TryGetPrice(string title, out double price)
            {
                if (title == "Clean Code")
                {
                    price = 25.5;
                    return true;
                }
                price = 0;
                return false;
            }
            // Task 10: PrintBookInfo method
            static void PrintBookInfo(string title, int pages = 300)
            {
                Console.WriteLine($"Title: {title}, Pages: {pages}");
            }
            // Task 11: PrintBookInfo method with named parameters
            static void PrintBookInfoNamed(string title, int pages = 300)
            {
                Console.WriteLine($"Title: {title}, Pages: {pages}");
            }
            // Task 12: PrintAllTitles method
            static void PrintAllTitles(params string[] titles)
            {
                foreach (string title in titles)
                {
                    Console.WriteLine(title);
                }
            }

        }

    }
}




      
   