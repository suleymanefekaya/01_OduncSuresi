using System;

class Program
{
    const int AzamiGun = 7;

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Ekipman şu anda ödünçte mi? (e/h): ");
        string? durumGirisi = Console.ReadLine();
        bool oduncte = durumGirisi?.Trim().ToLower() == "e";

        Console.WriteLine("Gün sayısı girin (çıkmak için q).");

        string? giris = "";
        while (giris != "q")
        {
            Console.Write("Kaç gün? ");
            giris = Console.ReadLine();
            if (giris == null || giris == "q")
                break;

            Console.WriteLine(TalepDegerlendir(oduncte, giris));
        }
    }

    static string TalepDegerlendir(bool oduncte, string giris)
    {
        if (oduncte)
            return "Reddedildi: ekipman şu anda ödünçte.";

        if (!int.TryParse(giris, out int gun))
            return "Reddedildi: sayı girmelisiniz.";

        if (gun < 1 || gun > AzamiGun)
            return $"Reddedildi: süre 1-{AzamiGun} gün arasında olmalı.";

        return $"Onaylandı: {gun} gün ödünç verilebilir.";
    }
}