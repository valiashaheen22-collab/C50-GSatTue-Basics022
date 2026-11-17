#region Question 1
//Q01.  Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in avariable of type object. Print it
////using System;

////namespace ConsoleApp16
////{
////    class Book
////    {
////        public string Title { get; set; }
////        public int Pages { get; set; }
////    }

////    class Program
////    {
////        static void Main(string[] args)
////        {
////            object book = new Book();
////            Console.WriteLine(book);
////        }
////    }
////}


#endregion
#region Question 2
//Q02.  Using the Book class above, print the result of calling ToString(), Equals() (compare book withitself), GetHashCode(), and GetType() on book.using System;

////class Book
////{
////    public string Title { get; set; }
////    public int Pages { get; set; }
////}

////class Program
////{
////    static void Main(string[] args)
////    {
////        object book = new Book();

////        Console.WriteLine(book.ToString());
////        Console.WriteLine(book.Equals(book));
////        Console.WriteLine(book.GetHashCode());
////        Console.WriteLine(book.GetType());
////    }
////}

#endregion
#region Question 3
//Q03.  Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.int pages = "464";

////class Program
////{
////    static void Main(string[] args)
////    {
////        int pages = 464;
////        Console.WriteLine(pages);
////    }
////}


#endregion
#region Question 4
//Q04.  Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide byzero", and then prints "Done" in a finally block.

////class Program
////   {
////       static void Main(string[] args)
////       {
////           int zero = 0;

////           try
////           {
////               int result = 10 / zero;
////               Console.WriteLine(result);
////           }
////           catch (DivideByZeroException)
////           {
////               Console.WriteLine("Cannot divide by zero");
////           }
////           finally
////           {
////               Console.WriteLine("Done");
////           }
////       }
////   }

#endregion
#region Question 5
//Q05.  Declare an int pages = 300; then store it in a double variable without using a cast.using System;
////class Program
////  {
////      static void Main(string[] args)
////      {
////          int pages = 300;
////          double doublePages = pages;

////          Console.WriteLine(doublePages);
////      }
////  }

#endregion
#region Question 6
//Q06.  Declare a double price = 29.95; then store it in an int variable using a cast.using System;
////class Program
////    {
////        static void Main(string[] args)
////        {
////            double price = 49.99;
////            int intPrice = (int)price;

////            Console.WriteLine(intPrice);
////        }
////    }
///

#endregion
#region Question 7
//Q07.  Given string pagesText = "464";, convert it into an int using the Convert class.
////class Program
//// {
////     static void Main(string[] args)
////     {
////         string pagesText = "464";
////         int pages = Convert.ToInt32(pagesText);

////         Console.WriteLine(pages);
////     }
//// }

#endregion
#region Question 8
//Q08.  Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,use int.TryParse() to safely try converting it, and print "Invalid number" if it failsuse int.TryParse() to safely try converting it, and print "Invalid number" if it fails

////class Program
////{
////    static void Main(string[] args)
////    {
////        string yearText = "2023";
////        int year = int.Parse(yearText);

////        Console.WriteLine(year);

////        string badText = "abc";

////        bool success = int.TryParse(badText, out int number);

////        if (success == false)
////        {
////            Console.WriteLine("Invalid number");
////        }
////    }
////}

#endregion
#region Question 9
//Q09.  Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()to prove it's now a string.
////class Program
////  {
////      static void Main(string[] args)
////      {
////          int pages = 464;

////          string pagesString = pages.ToString();

////          Console.WriteLine(pagesString.GetType());
////      }
////  }

#endregion
#region Question 10
//Q10.  Declare int copies = 100;. Box it into an object variable, then unbox it back into a new intvariable, and print both
class Program
{
    static void Main(string[] args)
    {
        int copies = 100;

        object boxedCopies = copies;

        int unboxedCopies = (int)boxedCopies;

        Console.WriteLine(boxedCopies);
        Console.WriteLine(unboxedCopies);
    }
}
 
#endregion