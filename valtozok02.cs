//Referenciák
class MyClass
{
    public int x;
}
//Enum, a felsorolt típus
enum Allatok { Kutya, Macska, Tigris, Farkas };
//Alapértelmezetten, int típusúak de változhatunk rajta
enum Allatok2 : byte { Tehén, Tyúk, Zebra, Kacsa };

//Értéket is tudunk rendelni hozzá
enum Allatok3 : byte { Veréb = 1, Róka = 4, Vakond, Oroszlán };
class Program
{
    static void Main(string[] args)
    {
        //Referencia
        MyClass s = new MyClass();
        s.x = 10;
        MyClass p = s; 
        p.x = 14;
        Console.WriteLine(s.x); //Megváltozik az értéke, mert ugyanarra a memória területre hivatkozik majd mint az s.

        //enum
        Allatok a = Allatok.Macska;
        Console.WriteLine(a); //Macska
        Console.WriteLine(Allatok.Macska); //Macska
        //Megtudunk feleltetni, numerikus értéket
        int x = (int)a;
        Console.WriteLine(x); //1
        a = Allatok.Farkas;
        Console.WriteLine(a); //Farkasra változik az értéke
        x = (int)a;
        Console.WriteLine(x); //3-ra változik mert cast-oltunk.

        Allatok3 c = Allatok3.Vakond;
        Console.WriteLine((int)c); //4 


        //Dinamikus típus
        //Ez egy olyan típus, ami objektum bármit megtehet fordítási időben, olyat ami hibát okoznának
        dynamic g = 10;
        Console.WriteLine(g); //10
        g = "szalámi";
        Console.WriteLine(g); //szalámi

        //Konstansok
        //Arra jó hogy egy objektumot, konstanssá megváltozhatatlanná tegyünk.
        const int y = 10;
       
        Console.ReadKey();
    }
    
}
