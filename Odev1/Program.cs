namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Vize Final Notu Hesaplama");

            // Console'^dan girilen vize ve final notları ile ortalamayı hesaplayan bu ortalamaya göre harfnotunu bulup ekrana ortalama ve harfnotunu yazan prog. yazınız.. tanımladığım değişkenleri kullanınız... 


            float vize, final, ort=0;

            // vize notu isteyiniz

            // final notu isteyiniz

            // ortalama hesaplayınız
            // ortalam vize notunun %40 finalnotunun %60 formülü ile hesaplanır. Formül (vizenotu * 0.4) + (finalnotu * 0.6)
            Console.WriteLine("Vize Notunu Giriniz");
            vize = Convert.ToInt32(Console.ReadLine());

            vize = vize / 100 * 40;
            Console.WriteLine("Final  notunu giriniz");
            final = Convert.ToInt32(Console.ReadLine());
            final = final / 100 * 60;

            ort = vize + final;

            string harfNotu="";
            if (ort >=85 && ort <=100)
            {
                harfNotu = "AA";
            }
            else if (ort >= 75 && ort <= 84)
            {
                harfNotu = "BA";
            }
            else if (ort >= 65 && ort <= 74)
            {
                harfNotu = "BB";
            }
            else if (ort >= 50 && ort <= 64)
            {
                harfNotu = "CC";
            }
            else if (ort >= 25 && ort <= 49)
            {
                harfNotu = "DC";
            }

            else
            {
                harfNotu = "FF";
            }
            // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

            Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");


            // todo: bütün  istenilenleri switch-case ve if karar mekanizmaları kullanarak yapınız


            Console.WriteLine("Kapatmak  için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}