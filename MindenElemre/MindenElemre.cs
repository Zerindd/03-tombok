/* ISMÉTLÉS
 *
 * Korábban említettük, hogy a 'while' bármilyen ismétlésre alkalmas. 
 * De igazából csak akkor érdemes használni, ha előre még nem tudjuk, 
 * hányszor kell valamit ismételni. Gyakran pont ez akarjuk kideríteni.
 *
 * A 'for' sokszor praktikusabb, mert egy tömörebben megfogalmazott alak.
 * Előre tudjuk az ismétlések számát - a számláló csak ciklus közben kell.
 * Tipikus példa rá egy tömb bejárása, hiszen ekkor a méret előre adott.
 */

using System;

class MindenElemre
{
    static void Main()
    {
        /* FOREACH
         *
         * A 'foreach' ciklus még ennél is speciálisabb.
         * Kizárólag gyűjtemények "bejárására" alkalmas.
         * Ami egyelőre nekünk még csak a tömböt jelenti.
         *
         * A 'foreach' jelentése szemléletesen kiolvasva:
         * 
         * minden elemre egy gyűjteményben
         *    ismételd meg az utasításokat
         *
         * Ez a ciklus bejár egy gyűjteményt az elejétől a végéig.
         * Minden futamban az éppen vizsgált elemet elnevezi valahogy.
         * A ciklus akkor ér véget, ha minden elem sorrakerült.
         *
         * A foreach kulcsszó után zárójelben három dolgot kell megadnunk:
         * - milyen típusú értékeket tartalmaz a tömb
         * - az aktuális elemnek mi legyen az ideiglenes neve
         * - a tömb nevét, amit be akarunk járni
         */

        // Például:
        string[] osztalyNevsor = { "Anna", "Betti", "Csaba", "Dia" };

        // Ismételjük meg minden egyes elemre
        // - az osztalyNevsor azonosítójú tömbben
        // - ami 'string' típusú elemeket tartalmaz
        // - és az aktuális futamban ideiglenesen 
        // - 'egyNev'-ként hivatkozunk a vizsgált elemre.

        foreach (string egyNev in osztalyNevsor)
        {
            Console.WriteLine(" Az aktuális elem: " + egyNev);
        }

        Console.WriteLine();

        // Figyeljük meg, hogy nem használtunk indexet!
        // Azt sem mondtuk meg, honnan kezdjük a bejárást,
        // meddig menjünk el, vagy hogy mekkora ugrásokkal.
        // A 'foreach' valahogy "magától tudta" ezeket.

        /* FOR vs EACH */

        // Számoljuk ki egy tömbben található elemek összegét!

        int[] tomb = { 1, -18, 3, 53, -7, 0, 14 };

        // Először 'for' ciklussal

        int osszeg = 0;

        for (int i = 0; i < tomb.Length; i++)
        {
            // Az aktuális elemet eltárolhatnánk egy átmeneti változóban.
            // Mert néha olvashatóbb lenne, ha nem kéne minding indexelni.
            int elem = tomb[i];
            osszeg += elem;
        }
        Console.WriteLine("A tömbelemek összege 'for' szerint: " + osszeg);

        // Majd 'foreach' ciklussal

        osszeg = 0;

        foreach (int elem in tomb)
        {
            osszeg += elem;
        }
        Console.WriteLine("A tömbelemek összege 'foreach' szerint: " + osszeg);

        /* ELŐNYÖK
         *
         * - nem kell megmondai, hol a tömb eleje / vége
         * - a tömb elemeit egyáltalán nem kell indexelni
         * - de beszédes nevet kap az éppen vizsgált elem
         * - így praktikusabb, tömörebb, jobban olvasható
         * - ezért használjuk mindig ezt, amikor csak lehet
         */

        /* KÖLÖNBSÉGEK
         *
         * Amit viszont nem lehet 'foreach' ciklussal:
         * - nincs index, nem tudjuk elérni az előző/következő elemet
         * - az akutális elemet sem tudjuk lecserélni egy másikra
         * - tehát egy tömb módosítására általában nem alkalmas
         * - de például tökéletes minden egyes elem kiíratására
         */

        // Mindig használjuk az automatikus kódkiegészítőt! fore + tab + tab
        // Miután átírtunk valamit, újabb tab lenyomásra ugrik a következőre

        // Próbáljuk ki ujjgyakorlatként!
        // fore tab tab
        // i tab tab
        // szam tab
        // t tab
        
        /* EGÉSZSÉGES PROGRAMOZÓI "LUSTATSÁG"
         *
         * A 'var' kulcsszón nem is kötelező változtatni.
         * Így a fordítóra bízzuk a típus megállapítását.
         * Hiszen szigorúan típusos nyelvben egyértelmű,
         * hogy a korábban int[]-ként definiált tömbben
         * természetesen kizárólag egész számok lehetnek.
         * Az 'item' ugyanolyan elnevezés, mint 'for' ciklusnál az 'i'.
         * Ha csak 'foreach' ciklushoz használjuk, akár úgy is maradhat.
         */

        int[] collection = { 1, -18, 3, 53, -7, 0, 14 };

        int sum = 0;

        foreach (var item in collection)
        {
            sum += item;
        }
        Console.WriteLine(sum);

        Console.WriteLine();
        Console.Write("Vége ");
        Console.ReadKey();
    }
}
