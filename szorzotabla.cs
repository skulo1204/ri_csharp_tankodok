namespace szorzotabla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Szorzótábla:
             * Azért használunk 'args' tömböt hogy a program egy beállított értéknek függően, program futása során argumentumokat kapjon. Jelen esetben ez 10
             * Ha nem állítanánk be akkor az 'if' ág lefutna
             * Egyébként egyszerűbben is meglehet oldani.
            */ 
            int number;
            if (args.Length == 0)
            {
                Random r = new Random();
                number = r.Next(100);
            }
            else { 
                number = int.Parse(args[0]);
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} == {2}", i, number, i*number);
            }
            Console.ReadKey();
        }
    }
}