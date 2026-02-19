namespace uveghazrendszer
{
    internal class Program
    {


        static void Main(string[] args)
        {
			Kezelo k = new Kezelo("Kovács Péter", "kpeter", Szerepkor.ADMIN);
            Kezelo k1 = new Kezelo("Kiss Anna", "kanna", Szerepkor.KERTESZ);

			Console.WriteLine(k);
			Console.WriteLine(k1);
		}
    }
}
