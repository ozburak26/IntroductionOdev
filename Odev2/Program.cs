namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console'dan alınan ay'ın mevsimini yazdıran prorgramı yapınız.
            Console.WriteLine("Lütfen ay giriniz");
            string ay = Console.ReadLine();

            switch (ay)
            {


                case "aralık":
                    Console.WriteLine("Mevsim Kış");
                    Console.WriteLine("12.ay");
                    break;
                case "ocak":
                    Console.WriteLine("Mevsim Kış");
                    Console.WriteLine("1.ay");
                    break;
                case "şubat":
                    Console.WriteLine("Mevsim Kış");
                    Console.WriteLine("2.ay");
                    break;
                case "mart":
                    Console.WriteLine("Mevsim İlkbahar");
                    Console.WriteLine("3.ay");
                    break;
                case "nisan":
                    Console.WriteLine("Mevsim İlkbahar");
                    Console.WriteLine("4.ay");
                    break;
                case "mayıs":
                    Console.WriteLine("Mevsim İlkbahar");
                    Console.WriteLine("5.ay");
                    break;
                case "haziran":
                    Console.WriteLine("Mevsim Yaz");
                    Console.WriteLine("6.ay");
                    break;
                case "temmuz":
                    Console.WriteLine("Mevsim Yaz");
                    Console.WriteLine("7.ay");
                    break;
                case "agustos":
                    Console.WriteLine("Mevsim Yaz");
                    Console.WriteLine("8.ay");
                    break;
                case "eylul":
                    Console.WriteLine("Mevsim Sonbahar");
                    Console.WriteLine("9.ay");
                    break;
                case "ekim":
                    Console.WriteLine("Mevsim Sonbahar");
                    Console.WriteLine("10.ay");
                    break;
                case "kasım":
                    Console.WriteLine("Mevsim Sonbahar");
                    Console.WriteLine("11.ay");
                    break;

                default:
                    break;
            }


            // eğer ay;  aralık-ocak-şubat      girilirse ekrana KIŞ 
            // mart-nisan-mayıs       girilirse ekrana İLK BAHAR
            // haziran-temmuz-ağustos girilirse ekrana YAZ 
            // eylük-ekim-kasım       girilirse ekrana SON BAHAR
            // mesajlarını veren programı yazınız.. Girilen ay için kaçıncı ay olduunu yazınız ekrana n. Ay şeklinde yazınız..

            // örnek;
            // klavyeden girilen ocak ayı için çıktı aşağıdaki gibi olmalıdır;
            // KIŞ
            // 1. Ay


            // todo: bütün  istenilenleri switch-case ve if karar mekanizmaları kullanarak yapınız

            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}