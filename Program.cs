//MATEMATIKAI OPERÁTOROK

int x = 10;
int y = 3;
int z = x + y; //Összeadás eredménye 13
Console.WriteLine(z);
z = x - y; //7
Console.WriteLine(z); 
z = x * y; 
Console.WriteLine(z); //30
z = x / y; //10/3
Console.WriteLine(z);
z = x % y;
Console.WriteLine(z); //Osztás maradéka: 1

//RELÁCIÓS OPERÁTOROK
int a = 10;
int b = 23;

Console.WriteLine(a > b ); //Kiírja az eredményt: false
Console.WriteLine(a == b); //false
Console.WriteLine(a != b); //x nem egyenlő y-nal: true
Console.WriteLine(a <= b); //x kisebb-egyenlő mint y: true

//LOGIKAI ÉS FELTÉTELES OPERÁTOROK
bool l = true; //bool olyan változó típus ami csak igaz vagy hamis értéket vesz föl
bool k = true;

if (l == true && k == false)
{
    Console.WriteLine("Igaz1");
}

else if (l == true || k == false) //Igaz2 fog csak lefutni az igazságtábla miatt
{
    Console.WriteLine("Igaz2");
}

if (!(a==10))
{
    Console.WriteLine("'a' nem egyenlő 11-gyel");
}

x = 10;
y = 10;
Console.WriteLine((x == y) ? "Egyenlő" : "Nem egyenlő"); //Háromoperandasú (ternáris) operátor
Console.ReadKey();
//Ugyanis az ÉS (&&) operátornál következő az igaszságtábla
/* 
 * A = hamis B = hamis Eredmény: hamis
 * A = hamis B = igaz Eredmény: hamis
 * A = igaz B = hamis Eredmény: hamis
 * A = igaz B = igaz Eredmény: igaz
*/

//VAGY ( || ) operátornál következő az igazságtábla
/*
 * A = hamis B = hamis Eredmény: hamis
 * A = hamis B = igaz Eredmény: igaz
 * A = igaz B = hamis Eredmény: igaz
 * A = igaz B = igaz Eredmény: igaz
*/

/* Tagadás (negáció) igaszságtáblája
 * A = hamis Eredmény: Igaz
 * A = igaz Eredmény: Hamis
*/