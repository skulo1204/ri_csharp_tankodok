namespace vezerlesi_szerkezetek_01
{
    enum Animal { TIGER, WOLF, CAT, DOG};
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Elágazás
            * Van olyan eset amikor meg kell vizsgálnunk  egy állítást, attól függően hogy igaz vagy hamis
            * A programnak más-más utasítást kell végrehajtania
            * Ilyen esetekbe használunk elágazást
            */
            int x = 10;
            if (x == 10)
            {
                Console.WriteLine("x értéke 10");
            }
            /* Mit írhatunk a feltételben?
             * Ha egyenlőséget vizsgálunk, mindig kettő egyenlőséget '==' írhatunk, ha pedig sima egyenlőséget írunk a feltételben pl: if (x=10) ez fordtási hiba
             * A feltételben szereplő kifejezésnek minden esetben logikai értéket kell visszaadnia, vagy pedig eredménynek konvertálhatónak kell lennie bool típusra
             * Nem írhatunk továbbá, numerikus értéket visszaadó kifejezést, illetve null értéket sem vizsgálhatunk pusztán referencia nevének megadásávál
            */
            /* Else
             * Akkor használjuk, amikor olyan helyzet adódik mikor a fent említett 'x' értéke nem 10
             * Illetve akkor lép működésbe, ha feltétel(ek) nem igaz(ak), önmagában az 'else' ág nem állhat.
            */
            else
            {
                Console.WriteLine("x értéke nem 10");
            }
            if (x != 10) //De ezt is írhattam volna.
            {
                Console.WriteLine("x értéke nem 10");
            }
            // Az utóbbival (x!=10) csak óvatosan, hiszen előfordulhat olyat eset amikor mindkét feltétel igaz.
            // Ha több feltételt szeretnénk megvizsgálni else-if lesz a mi barátunk
            else if (x == 12)
            {
                Console.WriteLine("x értéke 12");
            }
            //Egy elágazásban egy db if, bármennyi else-if és pontosan egyetlen egy else ág lehet.

            /* switch-case
             * Akkor használjuk, ha egy változó több lehetséges állapotát akarjuk vizsgálni.
             * Az ágak a kijelölt feladatuk végrehajtása után a break utasítással kilépnek a szerkezetből.
             * Ha nincs olyan szám amely kezelné az éppen aktuális értéket, akkor vagy a deault ág kapja meg a vezérlést, vagy ha nem írtunk ilyet akkor a switch automatice kilép a switch szerkezetből.
            */
            int a = 11;
            switch (a)
            {
                case 10:
                    Console.WriteLine("a értéke 10");
                    break;
                case 11:
                    Console.WriteLine("a értéke 11");
                    break;
                default:
                    Console.WriteLine("O óó");
                    break;

            }
            /* A C# nem engedélyezi hogy break utasítás hiányában egyik állapotból átcsússzunk egy másikba.
             * Ez alól szabály egyetlen kívétel van, ha az adott ág nem tartalmaz semmilyen utasítást.
             * Például:
            */
            Animal animal = Animal.DOG;
            switch (animal)
            {
                case Animal.TIGER:
                case Animal.DOG:
                default:
                    Console.WriteLine("Ez egy állat!");
                    break;
            }
            // A break utasításon kívül használhatjuk a goto-t is, ekkor átugorhatunk a megadott ágra.
            switch (animal)
            {
                case Animal.TIGER:
                    goto default;
                case Animal.DOG:
                    goto default;
                default:
                    Console.WriteLine("Ez egy állat");
                    break;
            }

            Console.ReadKey();
        }
    }
}