namespace IlkSinif
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person ogrenci1 = new Person();//öğreci nesnesi oluşturuldu.
            Person ogretmen1 = new Person();//öğretmen nesnesi oluşturuldu.
            ogrenci1.Ad = "Merve";
            ogrenci1.Soyadi = "Çelik";
            ogrenci1.DogumTarihi = new DateTime(1995, 10, 12);
            ogretmen1.Ad = "Enes";
            ogretmen1.Soyadi = "Çolak";
            ogretmen1.DogumTarihi = new DateTime(1985,12,10);

            Console.WriteLine("Öğrenci 1:");
            Console.WriteLine($"Ad: {ogrenci1.Ad}");
            Console.WriteLine($"Soyad: {ogrenci1.Soyadi}");
            Console.WriteLine($"Doğum Tarihi: {ogrenci1.DogumTarihi:dd.MM.yyyy}");

            Console.WriteLine();

            Console.WriteLine("Öğretmen 1:");
            Console.WriteLine($"Ad: {ogretmen1.Ad}");
            Console.WriteLine($"Soyad: {ogretmen1.Soyadi}");
            Console.WriteLine($"Doğum Tarihi: {ogretmen1.DogumTarihi:dd.MM.yyyy}");

        }
    }
}
