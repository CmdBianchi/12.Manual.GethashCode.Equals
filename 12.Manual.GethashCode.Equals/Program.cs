using System;
namespace _12.Manual.GethashCode.Equals {
    class Program {
        static void Main(string[] args) {
            // ------- > EQUALS

            string a = "Maria";
            string b = "Alex";

            bool tf = a.Equals(b);
            Console.WriteLine(tf);

            // ------- > GetHashCode

            string c = "Maria";
            string d = "Alex";
            
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());

            // GetHashCode | Bonus | TERNARIA 

            string strResultado;
            strResultado = c.GetHashCode() == d.GetHashCode() ? "True" : "False";
            Console.WriteLine(strResultado);
        }
    }
}
