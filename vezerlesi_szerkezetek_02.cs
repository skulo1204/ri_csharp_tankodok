using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace vezerlesi_szerkezetek_02
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Amikor egy adott utasítássorozatott többször kell végrehajtanunk, akkor ciklust használunk. A C# négyféle ciklust biztosít számunkra.
             * For ciklus
             * While ciklus
             * Do-While ciklus
             * Foreach ciklus
            */
            /* For ciklus
             * Ún. számláló ciklusnak hívjuk
             * Példaul:
            */
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------");
            /* Lényege:
             * Megmondjuk hogy honnét kezdődjön az állapota, jelen esetben ez 0-tól kezdődik
             * A léptetés részen egy művelet van, ami minden egyes "kör" után lefut.
             * A feltétel részen pedig egy feltétel felállításával megadhatjuk meddig fusson egy ciklus.
            */
            // Itt egy bonyolultabb példa
            for (int i = 0;i < 10 && i !=4; i++)
            {
                Console.WriteLine(i);
            }
            // Addig megy a ciklus, amíg az 'i' kisebb tíznél és nem egyenlő néggyel. Értelemszerűen csak háromig fogja kiírni a számokat.
            
            Console.WriteLine("--------------------------------------");
            // Itt egy összetett kifejezés
            for (int i = 0; i < 10; i+=2)
            {
                Console.WriteLine(i);
            }
            // Ebben a kódsorban kettesével növeltük a ciklusváltozót, vagyis páros számokat írtunk ki vele.
            Console.WriteLine("--------------------------------------");
            // Itt egy példa, egy végtelen ciklusra, amit inkább így kommentben hagynék.
            /*for(; ; )
            {
                Console.WriteLine("Végtelen ciklus");
            }
            */

            /* While ciklus:
             * Az elöl tesztelős (while-ciklus), olyan ciklus amely a ciklusmag végrehajtása előtt ellenőrzi a ciklusfeltételt.
             * Ezért előfordulhat az hogy a ciklus törzs egyszer sem fut le.
            */
            
            int j = 0;
            while (j<10)
            {
                Console.WriteLine("j értéke: {0}", j);
                j++;
            }
            // A While ciklus sokkal rugalmasabb hiszen, mivel több lehetőségünk van a ciklusfeltétel megválasztására.
            Console.WriteLine("--------------------------------------");

            /* Do-While ciklus
             * A ciklusmag végrehajtása után ellenőrzi a ciklusfeltételt, így legalább egyszer biztosan lefut.
            */ 
            int k = 0;
            do
            {
                Console.WriteLine("k értéke: {0}",k);
                k++;
            } while (k<10);
            Console.WriteLine("--------------------------------------");

            /* Foreach ciklus
             * Hasonló mint a for ciklus, de ezzel végigjárhatunk egy tömbön vagy gyűjteményen.
             * Példa, most már nem megszokott "számoljunk el kilencig", helyette
            */
            string str = "abcdefghijklmnopqrstuvwxyz";
            foreach (char ch in str)
            {
                Console.WriteLine(ch);
            }
            // A példában használt ch változó nem ciklusváltozó, hanem ún. iterációs változó, amely felveszi az iterált gyűjtemény aktuális elemének értékét.
            Console.WriteLine("--------------------------------------");

            foreach (int i in EnumerableMethod(10))
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

            /* +1 Yield
             * Lehetővé teszi hogy egy ciklusból olyan osztályt generáljon
             * Ezáltal használható legyen pl. a foreach ciklussal.
             * Működése elve: A legelső metódusmeghívásnál a ciklus megtesz egy lépést, ezután "kilépünk" a metódusból, annak állapotát megőrízzük.
             * A következő meghívásnál onnan folytatja ahonnan abbahagytuk.
            */

        static public IEnumerable EnumerableMethod(int max)
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
    }
}