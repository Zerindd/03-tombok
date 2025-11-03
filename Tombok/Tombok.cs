using System;

class Tombok
{
    static void Main()
    {
        // Egyetlen tanuló nevét tárolhatjuk szöveges változóként.

        string nev = "Anna";

        // Szeretnénk tárolni egy iskolai csoport tanulóinak nevét.
        // Ehhez jó néhány azonos típusú változóra szükségünk lesz.
        // Mindegyiknek egyedi azonosító kell. A 'név' már foglalt.
        // A többit megkülönböztethetnénk például sorszámozással.

        string nev1 = "Bence";
        string nev2 = "Csilla";
        string nev3 = "Dávid";
        string nev4 = "Endre";
        string nev5 = "Ferenc";
        string nev6 = "Gergő";
        string nev7 = "Helga";

        //... stb.

        // Gondoljunk bele: ez még csak egyetlen csoport névsora!
        // Mi a helyzet egy iskolával, ahova többszáz tanuló jár?
        // Praktikus lenne, ha létezne erre valamiféle "gyűjtő".
        // Amiben egyszerre kezelhetnénk sok hasonló változót...

        /* TÖMB ('array')
         *
         * Egy gyűjtemény, amiben együtt kezelünk összetartozó adatokat.
         * A típusuk tetszőleges, de egyetlen tömbben csak azonosak lehetnek.
         * Tehát kizárólag csak számok, vagy csak szövegek, vagy csak stb.
         * Tömböt bevezetni a tárolandó típus megadásával lehet, majd az ún.
         * tömbképző operátort kell leírni [], végül adni kell egy egyedi névet.
         */

        // Például egész számok tárolására alkalmas tömb:
        int[] tomb;

        // Akárcsak az egyszerű változók esetén, ez csak "deklaráció".
        // Csak bevezet egy azonosítót, amivel majd hivatkozhatunk rá.
        // A tömböt a használat előtt még "inicializálni" is kell. 

        // Ezt a "new" kulcsszóval tehetjük meg. Ekkor kell megadnunk azt is,
        // hogy mekkora méretű legyen. Hány érték tárolására legyen képes?
        // Például ebben a tömbben majd 5 darab egész számot tarhatunk:

        tomb = new int[5];

        // A tömb mérete fix. Létrehozásakor kell eldönteni, legfeljebb mennyi
        // adatot akarunk majd tárolni. Ezt később már nem tudjuk módosítani!
        // A mérethez természetesen nem csak számliterált használhatunk,
        // hanem valamilyen kifejezés eredményét, változót vagy függvényt is.

        tomb = new int[ (4 * 5) - 3 ];

        int meret = 20;
        tomb = new int[meret];

        Console.Write("Mekkora legyen a tömb mérete? ");
        tomb = new int[ Convert.ToInt32( Console.ReadLine() ) ];

        // Ahogy korábban az egyszerű változóknál már megszokhattuk,
        // a deklaráció és inicializáció írható egyetlen utasításként.
        // típus [] azonosító = new típus [ méret ];

        // Például stringeket tartalmazó 5 elemű tömb létrehozása, 
        // amire később 'nevek'-ként hivatkozhatunk:

        string[] nevek = new string[5];

        // Nézzük meg mi történik, ha a konzolra íratunk 
        // egy olyan változót, amivel tömre hivatkozunk!

        Console.WriteLine(nevek);
        Console.WriteLine();

        /* TÖMB ELEMEINEK ELÉRÉSE
         *
         * A tömbben tárolt értékeket a tömb "elemeinek" nevezzük.
         * Az egyes elemekre a saját sorszámukkal hivatkozhatunk.
         * Ez egyedi számérték, amit az elem "indexének" nevezünk.
         * A C# nyelvben a tömb elemeinek sorszámozása 0-tól indul. 
         * Tehát az első elem indexe a 0, a másodiké az 1, stb.
         * Ebből az is következik, hogy az utolsó lehetség index
         * mindig eggyel kisebb, mint a tömb mérete. Például:
         */

        nevek[0] = "Bruce";      // 1. elem 
        nevek[1] = "Cornelius";  // 2. elem
        nevek[2] = "Dallas";     // 3. elem
        nevek[3] = "Zorg";       // 4. elem
        nevek[4] = "Leeloo";     // 5. elem

        Console.WriteLine($"{ nevek[4] } az ötödik elem");

        // Próbáljuk ki!
        Console.Write("HÁNYADIK elemre vagy kíváncsi? (1-től 5-ig) ");
        int hanyadik = int.Parse(Console.ReadLine());

        Console.WriteLine($"A tömb { hanyadik }. eleme { nevek[hanyadik - 1] }");
        Console.WriteLine();

        Console.Write("Hányas INDEXŰ elemre vagy kíváncsi? (0-tól 4-ig) ");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine($"A tömb { index } indexű eleme { nevek[index] }");
        Console.WriteLine();

        /* SZEMLÉLTETÉS
         *
         * A számolást 0-tól kezdeni, és ezért eggyel hamarabb befejezni
         * elsőre szokatlannak tűnhet. Hiszen nem így "szoktunk" számolni.
         * De ha kicsit belegondolunk, valójában ez teljesen természetes.
         * 
         * Egy nap 24 óra. Az új nap 0 órával kezdődik, az utolsó a 23 óra.
         * Számjegyekből is összesen 10 darab van. De az érték 0-tól tart 9-ig.
         * Ha egy háznak három szintje van az földszint, első és második emelet.
         */

        /* TÖMB KEZDŐÉRTÉKE */

        // Tömböt úgy is megadhatunk, hogy azonnal értékekkel töltjük fel.
        // Az utasítást lezáró pontosvessző elé tehetünk egy { } karakterpárt.
        // Ezek között pedig vesszővel elválasztva felsorolhatjuk az elemeket.

        int[] egeszek = new int[7] { 9, 5, 7, 22, 29, 1, 47 };

        // Azt is megtehetjük, a méret megállapításást is a fordítóra bízzuk.
        double[] tortek = new double[] { 3.14, 2.865, 1.09, 10.7 };

        // Sőt, még a "new típusKulcsszó []" jeleket is elhagyhatjuk!
        char[] ekezetes = { 'á','é','í','ó','ö','ő','ú','ü','ű' };

        // Akár változókat is használhatunk
        string[] nevsor = { nev, nev1, nev2, nev3, nev4, nev5, nev6, nev7 };

        /* MIKOR PRAKTIKUS A TÖMB? 
         *
         * Ha több, azonos típusú, összetartozó értéket akarunk egyben kezelni.
         * Ha előre tudjuk, hogy hány darabra van, ami később sem fog változni.
         */

        // Például ha háromdimenziós koordináta rendszerben akarunk számolni.
        int x = 10;
        int y = -5;
        int z = 30; 

        int[] koordinatak = { x, y, z };

        // Például térképen GPS koordináták segítsévéel szeretnénk navigálni.
        double szelessegiFok = 47.565361;
        double hosszusagiFok = 19.0966553;

        double[] gps = { szelessegiFok, hosszusagiFok };

        // Például az IPv4 cím is mindig négy darab számból áll 0-tól 255-ig.
        byte[] ip = { 192, 168, 0, 1 };

        Console.WriteLine($"A router gyakran { ip[0] }.{ ip[1] }.{ ip[2] }.{ ip[3] }");
        Console.WriteLine();

        // Negyedéves vagy havi adatokból is jellemzően adott számú van.
        double[] negyedevesGDP = { 1.042, 1.038, 1.022, 1.051 };

        Console.WriteLine("GDP növekedés");
        Console.WriteLine($"1. negyedév: { negyedevesGDP[0] * 100 } %");
        Console.WriteLine($"2. negyedév: { negyedevesGDP[1] * 100 } %");
        Console.WriteLine($"3. negyedév: { negyedevesGDP[2] * 100 } %");
        Console.WriteLine($"4. negyedév: { negyedevesGDP[3] * 100 } %");
        Console.WriteLine();

        // Hány órám van a héten?
        int[] orarend = { 5, 6, 4, 7, 6, 0, 0 };

        Console.WriteLine("Ennyi órám van a héten");
        Console.WriteLine($"Hétf { orarend[0] } óra");
        Console.WriteLine($"Kedd { orarend[1] } óra");
        Console.WriteLine($"Szer { orarend[2] } óra");
        Console.WriteLine($"Csüt { orarend[3] } óra");
        Console.WriteLine($"Pént { orarend[4] } óra");
        Console.WriteLine($"Szom { orarend[5] } óra");
        Console.WriteLine($"Vasr { orarend[6] } óra");
        Console.WriteLine();

        /* TÖMB MÉRETE */

        // Tömb méretét a .Length tulajdonsággal segítségével is megkaphatjuk

        Console.WriteLine($"A csoportba { nevsor.Length } tanuló jár.");
        Console.WriteLine($"Az IPv4 címet { ip.Length } bájt alkotja.");
        Console.WriteLine($"Egy év { negyedevesGDP.Length } negyedévből áll.");
        Console.WriteLine($"Egy hét { orarend.Length } napból áll.");
        Console.WriteLine();
        
        /* INDEXELÉS
         *
         * A rossz indexelés típushiba! Az "alul" indexelést a szövegértelmező 
         * ráadásul csak figyelmeztetésként jelzi, nem hibaként. Ellenpélda:
         * 
         * nevek[-1] = "nem lehetne negatív";
         *
         * A "túl" indexelésért viszont egyáltalán nem is szól! Ellenpélda:
         * 
         * nevek[99] = "itt vajon mi történik?";
         *
         * Futtatáskor azonban "IndexOutOfRangeException" hibával leáll
         * a program futása "Az index a tömb határain kívülre mutatott".
         */

        Console.Write("Vége ");
        Console.ReadKey();
    }
}
