using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.IO;
using static Linq_Assignment_01.ListGenerator;

namespace Linq_Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderingOperators();
        }

        static void RestrictionOperators()
        {
            var result = ProductList.Where(p => p.UnitsInStock == 0);

            result = ProductList.Where(p =>p.UnitsInStock == 0 && p.UnitPrice > 3.00M);

            foreach (Product item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void ElementOperators()
        {
            var result = ProductList.First(P => P.UnitsInStock == 0);

            result = ProductList.FirstOrDefault(result => result.UnitPrice > 1000);

            Console.WriteLine(result?.ProductName??"Null");

            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result01 = Arr.Where(a => a > 5).ToArray();
            Array.Sort(result01);
            Console.WriteLine(result01[1]);
        }
        static void AggregateOperators() 
        {
            ///1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count((a) => a%2 == 1);
            //Console.WriteLine(result);

            ///2. Return a list of customers and how many orders each has.
            //var result02 = CustomerList.Select(c => new { c.CustomerID, c.CustomerName ,orderCount = c.Orders.Length });
            //foreach (var item in result02)
            //{
            //    Console.WriteLine(item);
            //}

            ///3.Return a list of categories and how many products each has
            //var result03 = ProductList.Select(p=>p.Category).Distinct().ToArray();
            //var productsCount = ProductList.Count(p => p.Category == result03[0]);
            //foreach (var item in result03)
            //{
            //    productsCount = ProductList.Select(p => new { p.Category, p.ProductName }).Count(p => p.Category == item);
            //    Console.WriteLine($"there is  {productsCount} products in {item}" ); 
            //}

            ///4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine(Arr.Sum());



            /*string[] text = File.ReadAllLines("dictionary_english.txt");*/
            ///5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //Console.WriteLine(text.Count() + text.Select(t => t.Length).Sum());

            ///6.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //Console.WriteLine(text.OrderBy(txt => txt.ToString().Length).FirstOrDefault().ToString().Length);

            ///7.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //Console.WriteLine(text.OrderByDescending(txt => txt.ToString().Length).FirstOrDefault().ToString().Length);

            ///8.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //Console.WriteLine(text.Select(t => t.Length).Sum() / text.Count());

        }

        static void OrderingOperators()
        {
            ///1. Sort a list of products by name
            //var result = ProductList.Select(p => new {p.ProductName, p.Category})
            //                        .OrderBy(p => p.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ///2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var resut02 = Arr.OrderBy(a => a);
            //foreach (var item in resut02)
            //{
            //    Console.WriteLine(item);
            //}

            ///3. Sort a list of products by units in stock from highest to lowest.
            //var result03 = ProductList.Select(p => new { p.ProductName, p.Category , p.UnitsInStock})
            //                          .OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in result03)
            //{
            //    Console.WriteLine(item);
            //}

            ///4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result04 = Arr.OrderBy(a => a.Length).ThenBy(a => a);

            //foreach (var item in result04)
            //{
            //    Console.WriteLine(item);
            //}

            ///5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var resut05 = Arr.OrderBy(a => a.Length).ThenBy(a=>a);
            //foreach (var item in resut05)
            //{
            //    Console.WriteLine(item);
            //}

            ///6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var result06 = ProductList.Select(p=> new {p.Category, p.UnitPrice }).OrderByDescending(p => p.Category).ThenBy(p => p.UnitPrice);
            //foreach (var item in result06)
            //{
            //    Console.WriteLine(item);
            //}


            ///7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result07 = Arr.OrderBy( a => a.Length).ThenByDescending(a => a);
            //foreach (var item in result07)
            //{
            //    Console.WriteLine(item);
            //}


            ///8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string [] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result08 = Arr.Where(a => a[1]=='i');
            //foreach (var item in result08)
            //{
            //    Console.WriteLine(item);
            //}
        }

        static void TransformationOperators()
        {
            ///1. Return a sequence of just the names of a list of products.
            //var result = ProductList.Select(p => p.ProductName);
            //foreach(var item in result) 
            //{
            //    Console.WriteLine(item);
            //};

            ///2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry"};
            //var result01 = words.Select(x => new {UpperCase = x.ToUpper(), LowerCase = x.ToLower()}) ;
            //foreach (var item in result01)
            //{
            //    Console.WriteLine(item);
            //};

            ///3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var result02 = ProductList.Select(p => new { p.ProductName, price = p.UnitPrice });
            //foreach (var item in result02)
            //{
            //    Console.WriteLine(item);
            //};

            ///4. Determine if the value of int in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result03 = Arr.Select((a,i)=> new { i = i , number = a } );
            //foreach(var item in result03)
            //{
            //    if (item.i == item.number)
            //    {  
            //        Console.WriteLine(item);    
            //    }
            //}

            ///5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result04 = from num in numbersA
            //               from num2 in numbersB
            //               select num < num2 ? $"{num} is less than {num2}":$"{num} is more than {num2}";
            //foreach (var item in result04)
            //{
            //    Console.WriteLine(item);
            //}

            ///6.Select all orders where the order total is less than 500.00.
            //var result05 = CustomerList.SelectMany(C => C.Orders).Where(O => O.Total > 500.00M);
            //foreach (var item in result05)
            //{
            //    Console.WriteLine(item);
            //}

            ///7.Select all orders where the order was made in 1998 or later.
            //var result06 = CustomerList.SelectMany(C => C.Orders).Where(O => O.OrderDate >= new DateTime(1998,1,1));

            //foreach (var o in result06)
            //{
            //    Console.WriteLine(o.ToString());  
            //}
        }


    }
}