namespace Reversi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabla ujTabla = new Tabla("allas.txt");
            Console.WriteLine("5. feladat");
            ujTabla.Megjelenit();
            Console.WriteLine("6. feladat: Összegzés:");
            Console.WriteLine($"\tKék korongok száma: {ujTabla.MezokSzama('K')}");
            Console.WriteLine($"\tFehér korongok száma: {ujTabla.MezokSzama('F')}");
            Console.WriteLine($"\tÜres korongok száma: {ujTabla.MezokSzama('#')}");
            string parameterek = "F;4;1;0;1";
            Console.WriteLine($"8. feladat: [jatekos;sor;oszlop;iranySor;iranyOszlop] = {parameterek}");
            
            string[] elemek = parameterek.Split(';');
            char j = char.Parse(elemek[0]);
            byte s = byte.Parse(elemek[1]);
            byte o = byte.Parse(elemek[2]);
            byte iS = byte.Parse(elemek[3]);
            byte iO = byte.Parse(elemek[4]);

            if (ujTabla.VanForditas(j, s, o, iS, iO))
            {
                Console.WriteLine("Van fordítás!");
            }
            else
            {
                Console.WriteLine("Nincs fordítás!");
            }
        }
    }
}