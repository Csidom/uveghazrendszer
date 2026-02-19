namespace uveghazrendszer
{
    internal class Program
    {


        static void Main(string[] args)
        {
			Kezelo k = new Kezelo("Nagy Antal", "nantal", Szerepkor.ADMIN);
            Kezelo k1 = new Kezelo("Kiss Anna", "kanna", Szerepkor.KERTESZ);

            Novenyfaj n1 = new Novenyfaj("Paradicsom", 100, 10, 10);
            Cella cella = new Cella(new Pozicio(0, 0));
            Console.WriteLine(cella.UresCella);

            cella.Beultet(n1, 5);
			Console.WriteLine(cella.UresCella);
		}
    }
}
