namespace ConsoleApp12
{
    internal class Program
    {
        static List<string> isimler = new() { "Sümeyra", "Berkay", "Ceyda", "Arda", "Hira" };
        static List<string> bolumler = new() { "IK", "Satis", "Pazarlama", "Arge", "Satin Alma" };
        static List<Personel> personelListesi = new();
        static List<Musteri> musteriListesi = new();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Random random1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                personelListesi.Add(new() { AdSoyad = isimler[random1.Next(isimler.Count)], Departman = bolumler[random1.Next(bolumler.Count)] });
            }
            for (int i = 0; i < 10; i++)
            {
                musteriListesi.Add(new() { AdSoyad = isimler[random1.Next(isimler.Count)] });
            }
            List<Object> piknikTayfasi = new();
            piknikTayfasi.AddRange(musteriListesi);
            piknikTayfasi.AddRange(personelListesi);
            Yazdir(piknikTayfasi);
        }
        static void Yazdir(List<Object> tayfa)
        {
            foreach (var item in tayfa)
            {
                if (item is Personel)
                {
                    Personel personel = (Personel)item;
                    Console.WriteLine(personel.AdSoyad);
                }
                else
                {
                    Musteri musteri = (Musteri)item;
                    Console.WriteLine(musteri.AdSoyad);
                }

            }
        }
        static void MarkajListesiYazdır()
        {
            var MarkajListesi = musteriListesi.Zip(personelListesi);
            foreach (var item in MarkajListesi)
            {
                Console.WriteLine("{0} - {1}",
                item.First.AdSoyad, item.Second.AdSoyad);
                Tuple<Personel, Musteri> t;
            }
        }
    }
    class MarkajItem
    {
        public Personel First { get; set; }
        public Musteri Second { get; set; }
    }
    class Personel
    {
        public string AdSoyad { get; set; }
        public string Departman { get; set; }
    }
    class Musteri
    {
        public string AdSoyad { get; set; }
    }
}