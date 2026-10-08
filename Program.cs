
using KonyvNyilvantartas;

List<Konyv> konyvek = new List<Konyv>();

for (int i = 0;i<3;i++)
{
    Konyv peldany=new Konyv();

    Console.WriteLine($"\n{i + 1}. könyv adatai:");

    Console.Write("\tCím: ");
    peldany.cim = Console.ReadLine();

    Console.Write("\tSzerző: ");
    peldany.szerzo = Console.ReadLine();

    Console.Write("\tOldalszám: ");
    peldany.oldalszam=int.Parse(Console.ReadLine());

    konyvek.Add(peldany);
}

Console.WriteLine("\nRögzített könyvek listája:");

int ossz = 0;
for (int i = 0; i<konyvek.LongCount(); i++)
{
    ossz += konyvek[i].oldalszam;
    Console.WriteLine($"\t- {konyvek[i].cim} ({konyvek[i].szerzo}) - {konyvek[i].oldalszam} oldal");
}

Console.WriteLine($"\nÖsszesen elolvasandó: {ossz} oldal");