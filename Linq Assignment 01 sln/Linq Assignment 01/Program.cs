using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.IO;
using static Linq_Assignment_01.ListGenerator;
using System.Diagnostics.Metrics;
using System.Xml;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Collections.Concurrent;
using static System.Net.Mime.MediaTypeNames;

namespace Linq_Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grouping();
        }
        #region Linq_Assignment_01

        static void RestrictionOperators()
        {
            var result = ProductList.Where(p => p.UnitsInStock == 0);

            result = ProductList.Where(p => p.UnitsInStock == 0 && p.UnitPrice > 3.00M);

            foreach (Product item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void ElementOperators()
        {
            var result = ProductList.First(P => P.UnitsInStock == 0);

            result = ProductList.FirstOrDefault(result => result.UnitPrice > 1000);

            Console.WriteLine(result?.ProductName ?? "Null");

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

        #endregion

        #region Linq_Assignment_02

        public static string getLastCharacters(string text, int charactersCount)
        {
            int length = text.Length;
            int offset = Math.Max(0, length - charactersCount);
            return text.Substring(offset);
        }

        static void SetOprators()
        {
            //1.Find the unique Category names from Product List
            var Catagories = ProductList.Select(P => P.Category).Distinct().ToList();

            //2.Produce a Sequence containing the unique first letter from both product and customer names.
            var UniqueLetter = ProductList.Select(P => P.ProductName)
                                          .Concat(
                                             CustomerList.Select(C => C.CustomerName)
                                           ).Select(S => S[0]).ToArray().Distinct();
            //3.Create one sequence that contains the common first letter from both product and customer names.

            //4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            var LastThreeLetters = ProductList.Select(P => P.ProductName)
                                              .Concat(
                                                CustomerList.Select(C => C.CustomerName)
                                                ).Select(S => getLastCharacters(S, 3));

            foreach (var item in LastThreeLetters)
            {
                Console.WriteLine(item);
            }
        } 

        static void AggregateOperators02()
        {
            //1.Get the total units in stock for each product category.
            ////var TotalPricePerCat = ProductList.Where(P=>P.UnitsInStock>0).GroupBy(P => P.Category);

            ////foreach (var item in TotalPricePerCat)
            ////{
            ////    Console.WriteLine(item.Key);
            ////    foreach (var cat in item)
            ////    {
            ////        Console.WriteLine($"---------------------{cat.ProductName}");
            ////    }
            ////    Console.WriteLine("=========================================");
            ////}

            //2.Get the cheapest price among each category's products

            ////var cheapestPriceAmongEachCategory = ProductList.MinBy(P => P.UnitPrice);
            ////Console.WriteLine(cheapestPriceAmongEachCategory);

            //3.Get the products with the cheapest price in each category(Use Let)

            ////var cheapestPriceInEachCategoryUseLet = from P in ProductList
            ////                                        group P by P.Category 
            ////                                        into GP
            ////                                        select GP.MinBy(P=>P.UnitPrice);

            ////cheapestPriceInEachCategoryUseLet = ProductList.GroupBy(p => p.Category)
            ////                                    .Select(GP=>GP.MinBy(P => P.UnitPrice)).ToArray();

            ////foreach (var item in cheapestPriceInEachCategoryUseLet)
            ////{
            ////    Console.WriteLine($"Cat: {item.Category} || ProductName: {item.ProductName} || Price: {item.UnitPrice}");
            ////}

            //4.Get the most expensive price among each category's products.

            ////var expensivePriceAmongEachCategory = ProductList.MaxBy(P => P.UnitPrice);
            ////Console.WriteLine(expensivePriceAmongEachCategory);

            //5.Get the products with the most expensive price in each category.

            ////var expensivePriceInEachCategoryUseLet = from P in ProductList
            ////                                        group P by P.Category
            ////                                        into GP
            ////                                        select GP.MaxBy(P => P.UnitPrice);

            ////expensivePriceInEachCategoryUseLet = ProductList.GroupBy(p => p.Category)
            ////                                    .Select(GP => GP.MaxBy(P => P.UnitPrice)).ToArray();

            ////foreach (var item in expensivePriceInEachCategoryUseLet)
            ////{
            ////    Console.WriteLine($"Cat: {item.Category} || ProductName: {item.ProductName} || Price: {item.UnitPrice}");
            ////}

            //6.Get the average price of each category's products.

            ////var averagePriceInEachCategoryUseLet = from P in ProductList
            ////                                         group P by P.Category
            ////                                        into GP
            ////                                         select GP.Average(P => P.UnitPrice);

            ////averagePriceInEachCategoryUseLet = ProductList.GroupBy(p => p.Category)
            ////                                    .Select(GP => GP.Average(P => P.UnitPrice)).ToArray();

            ////foreach (var item in averagePriceInEachCategoryUseLet)
            ////{
            ////    Console.WriteLine($"{item}");
            ////}


        }

        static void PartitioningOperators()
        {
            //1.Get the first 3 orders from customers in Washington
            ////var First3Orders = CustomerList.Where(C=>C.Country == "USA").Select(C=>new { C.CustomerName,Orders = C.Orders.Take(3) });

            ////foreach (var item in First3Orders)
            ////{
            ////    Console.WriteLine(item.CustomerName);
            ////    foreach (var order in item.Orders)
            ////    {
            ////        Console.WriteLine(order);
            ////    }
            ////}

            //2.Get all but the first 2 orders from customers in Washington.

            ////var AllButFirst2Orders = CustomerList.Where(C => C.Country == "USA").Select(C => new { C.CustomerName, Orders = C.Orders.Skip(2)});

            ////foreach (var item in AllButFirst2Orders)
            ////{
            ////    Console.WriteLine(item.CustomerName);
            ////    foreach (var order in item.Orders)
            ////    {
            ////        Console.WriteLine(order);
            ////    }
            ////}

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            ////var result01 = numbers.TakeWhile((number,index) => number > index);

            ////foreach (var number in result01)
            ////{
            ////    Console.WriteLine(number);
            ////}

            //4.Get the elements of the array starting from the first element divisible by 3.

            ////var result02 = numbers.TakeWhile(number=> number%3 == 0);

            ////foreach (var number in result02)
            ////{
            ////    Console.WriteLine(number);
            ////}


            //5.Get the elements of the array starting from the first element less than its position.

            ///Same as number 3 !!!
        }

        static void Qubtifiers()
        {
            //1.Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt
            //into Array of String First) contain the substring 'ei'.

            //var text = from line in File.ReadAllLines("dictionary_english.txt")
            //           where line.Contains("ei")
            //           select line;

            //foreach (var item in text)
            //{
            //    Console.WriteLine(item);
            //}

            //2.Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var GroupOfOutOfStockCategory = ProductList.GroupBy(P => P.Category).Where(Gp => Gp.Any(ProductInGP => ProductInGP.UnitsInStock == 0));

            //foreach (var group in GroupOfOutOfStockCategory)
            //{ 
            //    Console.WriteLine(group.Key);
            //}

            //3.Return a grouped a list of products only for categories that have all of their products in stock.


            //var GroupOfInStockCategory = ProductList.GroupBy(P => P.Category).Where(Gp => Gp.All(ProductInGP => ProductInGP.UnitsInStock != 0));

            //foreach (var group in GroupOfInStockCategory)
            //{
            //    Console.WriteLine(group.Key);
            //}

        }

        static void Grouping()
        {
            //1.Use group by to partition a list of numbers by their remainder when divided by 5
            ////List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            ////var DevidedBy5Group = numbers.GroupBy(Number=> Number%5);

            ////foreach (var item in DevidedBy5Group)
            ////{
            ////    Console.Write($"Numbers with a remainder of {item.Key} when devided by 5:");
            ////    foreach (var number in item)
            ////    {
            ////        Console.Write($" {number}");
            ////    }
            ////    Console.WriteLine();
            ////}

            //2.Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input
            ////var GroupedTextByFirstLetter = File.ReadAllLines("dictionary_english.txt").GroupBy(line => line[0]);

            ////foreach (var item in GroupedTextByFirstLetter)
            ////{
            ////    Console.Write($"lines start With the Letter: {item.Key}");
            ////    foreach (var line in item)
            ////    {
            ////        Console.Write($" {line}");
            ////    }
            ////    Console.WriteLine();
            ////}

            //3.Consider this Array as an Input
            string[] Arr = { "from", "salt", "earn", "last", "near", "form"};

            // First Triming Spaces an converting the all Chars to Lower Case in case of any upper case deffrancse 
            //then makes a new opject of ArrEqualityComparer to start Grouping passed on the character Sorting like (from and form) 
            //var orderGroups = Arr.GroupBy(
            //        w => w.Trim(),
            //        a => a.ToLower(),
            //        new ArrEqualityComparer()
            //        );

            //foreach (var v in orderGroups)
            //{
            //    Console.WriteLine(v.Key);
            //    foreach (var g in v)
            //    {
            //        Console.WriteLine(g);
            //    }
            //    Console.WriteLine();
            //}

        }

        public class ArrEqualityComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y)
            {
                // Takes two Values and Compare the result of getCanonicalString()
                return getCanonicalString(x) == getCanonicalString(y);
            }

            public int GetHashCode(string obj)
            {
                return getCanonicalString(obj).GetHashCode();
            }

            private string getCanonicalString(string word)
            {
                // Sorts the Characters of the Word like ABC... 
                // then return the String
                char[] wordChars = word.ToCharArray();
                Array.Sort<char>(wordChars);
                return new string(wordChars);
            }
        }
        #endregion
    }
}