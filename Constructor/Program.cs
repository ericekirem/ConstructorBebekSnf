using System;

namespace BabyApp
{
    public class Bebek
    {
        // (Properties)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        // Default Constructor
        public Bebek()
        {
            // Doğum Tarihi olarak şu anı atama
            BirthDate = DateTime.Now;
            Console.WriteLine("Ingaaaa"); // Konsol mesajı
        }

        // Parametre alan Constructor (Ad ve Soyad)
        public Bebek(string firstName, string lastName) : this() // Default constructor'u çağır
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Bebek bilgilerini yazdırmak için metot
        public void PrintInfo()
        {
            Console.WriteLine($"Ad: {FirstName}, Soyad: {LastName}, Doğum Tarihi: {BirthDate}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Default constructor ile bebek nesnesi oluşturma
            Bebek baby1 = new Bebek();
            baby1.FirstName = "Ahmet";
            baby1.LastName = "Yıldız";
            baby1.PrintInfo();

            // Parametreli constructor ile bebek nesnesi oluşturma
            Bebek baby2 = new Bebek("Elif", "Demir");
            baby2.PrintInfo();
        }
    }
}


