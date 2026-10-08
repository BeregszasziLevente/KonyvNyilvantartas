
using KonyvNyilvantartas;

List<Konyv> konyvek = new List<Konyv>();

for (int i = 0;i<3;i++)
{
    Konyv peldany=new Konyv();

    Console.Write("Cím: ");
    peldany.cim = Console.ReadLine();

    Console.Write("Szerző: ");
    peldany.szerzo = Console.ReadLine();

    Console.Write("Oldalszám: ");
    peldany.oldalszam=int.Parse(Console.ReadLine());

    konyvek.Add(peldany);
}

