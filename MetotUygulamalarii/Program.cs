class Program
{
    static void Main()    // Öncelikle Main metodu oluşturup metodları çağırıyoruz.
    {
        SarkiSozu();  // Geriye değer döndürmeyen metodu çağırma

        int kalan = RandomSayi();  //  Geriye değer döndüren metodu çağırma
        Console.WriteLine("Rastgele bir sayının 2Ye bölümünden kalan: " + kalan);

        int carpimSonucu = Carpim(2, 8);  // Parametre alıp geriye değer döndüren metodu çağırma
        Console.WriteLine("Çarpım: " + carpimSonucu);

        IsimSoyisim("Şura", "Taşbaşı");  //  Parametre alıp geriye değer döndürmeyen metodu çağırma

    }



    static void SarkiSozu()
    {
        Console.WriteLine("Kul Ahmet erken kalkar, \"Haydi ya nasip\" derdi.\nKimseler anlamazdı \"Ya nasip\" ne demekti.");
    }



    static int RandomSayi()
    {
        Random rnd = new Random();
        int sayi = rnd.Next();
        return sayi % 2;
    }



    static int Carpim(int a, int b)
    {
        return a * b;
    }



    static void IsimSoyisim(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim} ");
    }

}
