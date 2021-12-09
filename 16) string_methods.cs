using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // string methods

            // uppercase
            string a = "Hello, World!";
                a = a.ToUpper(); 

            System.Console.WriteLine(a); // HELLO, WORLD!

            // lowercase
            string b = "Hello, World!";
                b = b.ToLower(); 

            System.Console.WriteLine(b); // hello, world!

            // replace
            string c = "123*456*7890";
                c = c.Replace("*","-"); 

            System.Console.WriteLine(c); // 123-456-7890

            // insert
            string d = a.Insert(0,"@"); // this will add "@" in "a" string

            System.Console.WriteLine(d); // @HELLO, WORLD!
                                         
            // length
            System.Console.WriteLine(a.Length); // 13
                                                // 13 length in "a" string
            
            // substring
            string e = a.Substring(0,5); // from 0 character -> 5 character
            string f = a.Substring(7,5); // from 7 character -> 5 character
 
            System.Console.WriteLine(e); // HELLO
            System.Console.WriteLine(f); // WORLD

            // wait before closing
            Console.ReadKey();
        }
    }
}