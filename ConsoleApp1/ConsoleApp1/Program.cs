using System;

namespace ConsoleApp1
{
    class Program
    {

        //Delegeta ile alınan veriler aynı olmak zorunda

        // action ve Func ile kullanılır action daha hızlı çalışır çünkü return fonksiyonu yok.

        public static string ConcattedString = string.Empty;
       
    public static void Concat(string ilk, string son)
        {
            ConcattedString = ilk + son;
            Console.WriteLine(ilk + son);
        }


        static void Main(string[] args)
        {
            Action<string, string> testDelegate=Concat;
            testDelegate("x", "y");

             
            Console.WriteLine("Singleton'dan gelen nesne: " +ConcattedString);

           
            Console.ReadLine();




        }
    }
}
