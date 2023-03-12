//BIT OPERÁTOROK
/*Bitenkénti "ÉS" veszi a két operandus bináris alakját, és megfelelő bitpárokon elvégzi az "ÉS" műveletet
  * Azaz mindkét bit 1 állásban van, akkor az adott helyen az eredményben is lesz az lesz, egyébként 0
  * Pl: 01101101 AND 00010001 = 00000001
*/
using System.Runtime.CompilerServices;

Console.WriteLine(10&2); // 1010 & 0010 = 0010 = 2
/* A bitenkénti vagy hasonlóan működik, de végeredményben egy bit értéke akkor lesz 1 ha, operandus közül valamelyik adott bitje közül valamelyik legalább az
 * PL: 01101101 OR 00010001 = 01111101
 */
Console.WriteLine(10|2); //1010 | 0010 = 1010 = 10
/* Biteltolás balra
 * LÉNYEGE: A kettes számrendszerbeli alak "felső" bitjét eltoljuk, majd a jobb oldalon keletkező "üres" bitet nullára állítjuk
 * PL: 10001111 LEFT SHITFT = 100011110
 * Operátor: <<
*/
int x = 143;
Console.WriteLine(x<<1); //10001111 (=143) << 1 = 100011110 = 286

/* Biteltolás jobbra
 * LÉNYEGE: Az alsó bitet toljuk el, és felül pótoljuk a hiányt.
 * Operátor: >>
*/
Console.WriteLine(x>>1); //10001111 (=143) >> 1 = 010001111 = 71
/* Mikor használjuk?
 * Amikor, egy olyan programot építünk amely erősen épít a kettővel vagy hatványaival való szorzásra/osztásra
 * Processzor sokkal gyorsabban végzi el, mint a hagyományos szorzást, hiszen ez az egyik leglassabb művelet
*/

//RÖVID FORMA
x = x + 10; //Hosszabb
x += 10; //Rövidebb
//Egyébként minden aritmetikai operátornak létezik rövid formája
int a = 5;
Console.WriteLine(++a); 
Console.WriteLine(--a);
Console.WriteLine(a++);
Console.WriteLine(a--);
//Ezek növelik vagy csökkentik eggyel az operandust.

//EGYÉB OPERÁTOROK
//typeof az operandusa típusát adja vissza

if (typeof(int) == x.GetType()) // GetType a változó típusát adja vissza (Egyébként System.Object-hez tartozó metódus, így dobozolva van az objektum)
{
    Console.WriteLine("'x' típusa int");
}

//sizeof operátor a "paramétereként" megadott értéktípus méretét adja vissza. Kizárólag unsafe módban használható
unsafe
{
    Console.WriteLine(sizeof(int)); //FONTOS: hiszen az int 32 bites, azaz 4 byte. Ezért ír 4-et.
}
Console.ReadKey();