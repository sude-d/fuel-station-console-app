using System;
using System.Threading;

namespace ConsoleApp11
{
    internal class Program
    {
        static void HataliIslem(string mesaj)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine(mesaj);
            Thread.Sleep(2000);
        }

        static void BasariliIslem(string mesaj)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine(mesaj);
        }

        static void StandartEkranAyarla()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
        }

        static void Main(string[] args)
        {
            double kasa = 5000;
            double benzinTanki = 100, mazotTanki = 100, lpgTanki = 100;
            double benzinAlisFiyati = 63.74, mazotAlisFiyati = 72.41, lpgAlisFiyati = 33.36;
            double benzinSatisFiyati = benzinAlisFiyati * 1.3, mazotSatisFiyati = mazotAlisFiyati * 1.3, lpgSatisFiyati = lpgAlisFiyati * 1.3;

            bool anahtar = true;

            while (anahtar)
            {
                StandartEkranAyarla();

                Console.WriteLine(
                    $"kasa:{kasa}\n\n" +
                    $"benzin alış fiyatı:{benzinAlisFiyati}\n" +
                    $"mazot alış fiyatı:{mazotAlisFiyati}\n" +
                    $"lpg alış fiyatı:{lpgAlisFiyati}\n\n\n" +
                    $"benzin satış fiyatı:{benzinSatisFiyati}\n" +
                    $"mazot satış fiyatı:{mazotSatisFiyati}\n" +
                    $"lpg satış fiyatı:{lpgSatisFiyati}\n\n" +
                    $"benzin tankı:{benzinTanki}\n" +
                    $"mazot tankı:{mazotTanki}\n" +
                    $"lpg tankı:{lpgTanki}\n" +
                    $"istasyona akaryakıt almak için(a)\n" +
                    $"istasyona akaryakıt satmak için(s)\n" +
                    $"istasyondan çıkış için(q)\n" +
                    $"lütfen bir seçim yapın:"
                );

                ConsoleKey secim = Console.ReadKey().Key;

                switch (secim)
                {
                    case ConsoleKey.A:
                        StandartEkranAyarla();
                        Console.WriteLine(
                            "benzin için(b)\n" +
                            "mazot için(m)\n" +
                            "lpg için(l)\n" +
                            "lütfen bir seçim yapınız:"
                        );

                        ConsoleKey alisSecim = Console.ReadKey().Key;

                        if (alisSecim == ConsoleKey.B)
                        {
                            StandartEkranAyarla();
                            Console.WriteLine("miktar: ");
                            double benzinMiktar = double.Parse(Console.ReadLine() ?? "0");
                            double tutar = benzinMiktar * benzinAlisFiyati;

                            if (tutar <= kasa)
                            {
                                benzinTanki += benzinMiktar;
                                kasa -= tutar;
                                BasariliIslem("işlem başarılı");
                            }
                            else
                            {
                                HataliIslem("bakiye yetersiz");
                            }
                        }
                        else if (alisSecim == ConsoleKey.M)
                        {
                            StandartEkranAyarla();
                            Console.WriteLine("miktar: ");
                            double mazotMiktar = double.Parse(Console.ReadLine() ?? "0");
                            double tutar = mazotMiktar * mazotAlisFiyati;

                            if (tutar <= kasa)
                            {
                                mazotTanki += mazotMiktar;
                                kasa -= tutar;
                                BasariliIslem("işlem başarılı");
                            }
                            else
                            {
                                HataliIslem("bakiye yetersiz");
                            }
                        }
                        else if (alisSecim == ConsoleKey.L)
                        {
                            StandartEkranAyarla();
                            Console.WriteLine("miktar: ");
                            double lpgMiktar = double.Parse(Console.ReadLine() ?? "0");
                            double tutar = lpgMiktar * lpgAlisFiyati;

                            if (tutar <= kasa)
                            {
                                lpgTanki += lpgMiktar;
                                kasa -= tutar;
                                BasariliIslem("işlem başarılı");
                            }
                            else
                            {
                                HataliIslem("bakiye yetersiz");
                            }
                        }
                        else
                        {
                            HataliIslem("yanlış giriş yaptınız");
                        }
                        break;

                    case ConsoleKey.S:
                        StandartEkranAyarla();
                        Console.WriteLine(
                            "benzin için(b)\n" +
                            "mazot için(m)\n" +
                            "lpg için(l)\n" +
                            "lütfen bir seçim yapınız:"
                        );

                        ConsoleKey satisSecim = Console.ReadKey().Key;

                        if (satisSecim == ConsoleKey.B)
                        {
                            StandartEkranAyarla();
                            Console.WriteLine("miktar: ");
                            double benzinMiktar = double.Parse(Console.ReadLine() ?? "0");

                            if (benzinMiktar <= benzinTanki)
                            {
                                double tutar = benzinMiktar * benzinSatisFiyati;
                                benzinTanki -= benzinMiktar;
                                kasa += tutar;
                                BasariliIslem("işlem başarılı");
                            }
                            else
                            {
                                HataliIslem("yetersiz yakıt");
                            }
                        }
                        else if (satisSecim == ConsoleKey.M)
                        {
                            StandartEkranAyarla();
                            Console.WriteLine("miktar: ");
                            double mazotMiktar = double.Parse(Console.ReadLine() ?? "0");

                            if (mazotMiktar <= mazotTanki)
                            {
                                double tutar = mazotMiktar * mazotSatisFiyati;
                                mazotTanki -= mazotMiktar;
                                kasa += tutar;
                                BasariliIslem("işlem başarılı");
                            }
                            else
                            {
                                HataliIslem("yetersiz yakıt");
                            }
                        }
                        else if (satisSecim == ConsoleKey.L)
                        {
                            StandartEkranAyarla();
                            Console.WriteLine("miktar: ");
                            double lpgMiktar = double.Parse(Console.ReadLine() ?? "0");

                            if (lpgMiktar <= lpgTanki)
                            {
                                double tutar = lpgMiktar * lpgSatisFiyati;
                                lpgTanki -= lpgMiktar;
                                kasa += tutar;
                                BasariliIslem("işlem başarılı");
                            }
                            else
                            {
                                HataliIslem("yetersiz yakıt");
                            }
                        }
                        else
                        {
                            HataliIslem("yanlış giriş yaptınız");
                        }
                        break;

                    case ConsoleKey.Q:
                        anahtar = false;
                        break;

                    default:
                        HataliIslem("hatalı seçim");
                        break;
                }
            }
        }
    }
}