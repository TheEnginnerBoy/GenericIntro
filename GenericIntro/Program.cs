using System;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            isimler.Add("Ali");
            isimler.Add("Veli");
            isimler.Add("Ahmet");
            isimler.Add("Mehmet");
            isimler.Add("Kadir");

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

        }
    }
}
