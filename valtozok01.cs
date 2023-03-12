using System.Data.Common;
//A felsorolt típus, enum -- Olyan adatszerkezet ami meghatározott értékek, névvel ellátott halmazát képviseli.
//Csak önálló típusként vagy osztályon belül, metóduson kívül deklarálhatunk

enum Allatok { Kutya, Macska, Tigris, Farkas };
internal class Program
{
    private static void Main(string[] args)
    {
        int x; //deklaráció
        x = 10; //definíció 
        int y = 10; //deklaráció és definíció

        // Változó típusok
        byte a = 0; //0-255 8 bit-es szám
        char b = 'a'; //Egy Unicode karakter
        bool c = false; bool c2 = true; //Igaz, hamis Logikai típus
        int d = 0; //32 bites egész szám
        float f = 0; //Egyszeres pontosságú, lebegő pontos szám 
        double g = 0.1; //Kétszeres pontosságú, lebegő pontos szám
        string h = "hello world"; //Unicode karakterek szekvenciája

        //Alakítsuk át a "Hello World" programot, úgy hogy kiírandó szöveget egy változóba tesszük:
        string message = "Hello World";
        Console.WriteLine(message);


        //Bedobozolás és kidobozolás
        int xy = 10;
        object obj = x; //Bedobozolva
        int yx = (int)obj; //Kidobozolva 

        //Bedobozolás mégegyszer object-el
        /*
         * A boxing arra való, hogy egy értéktípus (ami valami okból értékként van tárolva, mert pl. így hatékony) illeszkedni tudjon a .Net referencia, illetve alapú világába.
         */

        //Bedobozolás, kidobozolás mégegyszer

        int xx = 10;
        object zz = xx;
        zz = (int)zz + 10;
        Console.WriteLine(xx); //10
        Console.WriteLine(zz); //20

        //enum, használata

        Allatok t = Allatok.Tigris;
        if (t.Equals(Allatok.Tigris))
        {
            Console.WriteLine("t változó egy Tigris...");
        }

        //Kiírjuk a képernyőre, ReadKey-el és ReadLine-al is lehet
        Console.ReadKey();
    }
}
