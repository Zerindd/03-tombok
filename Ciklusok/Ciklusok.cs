/* CIKLUSOK & TÖMBÖK
 *
 * A tömbök szerepe, hogy több értéket kezeljünk egyetlen változóban.
 * Ezekre az értékekre pedig az egyedi sorszámukkal tudunk hivatkozni.
 *
 * Eddig egyesével adtunk a tömb elemeinek értéket, 
 * majd mindegyik értéket külön-külön kérdeztük le.
 * Ez rengeteg gépeléssel és kódismétléssel járhat.
 * Ha a tömb méretét például a felhasználó adja meg,
 * akkor könnyen belátható, hogy lehetetlen lenne
 * az utasításokat előre, egyesével leprogramozni.
 *
 * 'For' ciklussal kényelmesen kezelhetünk tömböket:
 * - hiszen a tömb mérete ismert vagy lekérdezhető
 * - így mindig tudjunk meddig kell benne lépegetni
 * - az aktuális elemhez szükségünk van az indexére
 * - a ciklus számlálója erre tökéletesen alkalmas
 */

using System;

class Ciklusok
{
    static void Main()
    {
        // Vegyünk fel egy tömböt, aminek a méretét parancssorról olvassuk be!
        // Majd töltsük fel szövegekkel, amit szintén a felhasználó adhat meg!

        Console.Write("Mekkora legyen a tömb mérete? ");
        int meret = int.Parse(Console.ReadLine());
        string[] tomb = new string[meret];

        Console.WriteLine();

        // Számlálós ciklus indul 0-tól. Fut, amíg el nem érné a tömb méretét.
        // Egyesével léptetve. A tömb aktuális elemét az indexével érjük el.
        // Ami most pont az 'i' változó értéke. Kezdetben 0, majd 1, 2, 3 stb.
        // Egészen a méretnél eggyel kevesebbig. Ami az utolsó helyes index.

        for (int i = 0; i < meret; i++)
        {
            Console.Write($"A tömb {i} indexű eleme legyen: ");
            tomb[i] = Console.ReadLine();
        }

        Console.WriteLine();

        // Persze az sem kötelező, hogy az elejétől haladjunk a vége felé.
        // Írassuk ki a tömb elemeit fordított sorrendben!

        Console.WriteLine("A tömb elemei fordított sorrendben: ");

        // A számlálót indítsuk az utolsó lehetséges indextől:
        // ami a tömb méreténél tehát mindig eggyel kisebb.
        // Ismétlejük annyiszor, amíg el nem éri a tömb elejét:
        // a legkisebb lehetséges index a 0, negatív már nem lehet.
        // Minden futam után eggyel csökkentve 'i' értéketét (++ helyett --)

        for (int i = meret - 1; i >= 0; i--)
        {
            Console.WriteLine($"index [ { i } ] értéke { tomb[i] }");
        }

        // Ha ez az alak esetleg zavaró, használhatunk segédváltozót is.
        // Az utolsó lehetséges indexből mindig egyre többet vonunk ki.

        for (int i = 0; i < meret; i++)
        {
            int vegerolSzamitva = meret - 1 - i;
            Console.WriteLine(tomb[vegerolSzamitva]);
        }

        /* GYAKORLÁS */

        // Vegyünk fel egy "sokelemű" tömböt "véletelen" számokkal!

        int[] szamok = { 1, 5, 6, 7, 8, 5, 4, 6, 9, 1, 6, 8, 7 };

        // Kettesével léptetve állítsunk minden második elemet 0-ra!
        // Mielőtt még lefuttatnánk, gondolkodjuk egy pillatra!
        // Ilyenkor véletlenül túl tudunk indexelni a tömbön?

        for (int i = 1; i < szamok.Length; i += 2)
        {
            szamok[i] = 0;
        }

        // Állítsunk mindent negatívra az első és utolsó 3 elem kivételével!
        // Mielőtt még lefuttatnánk, gondolkodjuk egy pillatra!
        // Mi történik, nincs is ennyi elem? (például mert a tömb két elemű)

        for (int i = 3; i < (szamok.Length - 3); i++)
        {
            szamok[i] *= -1;
        }

        Console.WriteLine();

        // Írjuk ki az értékeket színesen! A negatív számokat pirossal,
        // ha az érték nullam akkor fehérrel, minden mást pedig zölddel.

        for (int i = 0; i < szamok.Length; i++)
        {
            if (szamok[i] < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (szamok[i] > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine(szamok[i]);
        }

        Console.ResetColor();

        Console.WriteLine();
        Console.Write("Vége ");
        Console.ReadKey();
    }
}
