// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kaç Adet Ögrenci var ?");
int n=Convert.ToInt32(Console.ReadLine());
int ort = 0;
int orttoplam = 0;
int genelorttoplam = 0;
string harfNotu = "";
string adsoyad = "";
decimal enb = decimal.MinValue;
decimal enk = decimal.MaxValue;
string enbadsoyad = "";
string enkadsoyad = "";

for (int i = 0; i < n; )
{
    int sıralama=1+ i;
    Console.WriteLine(sıralama.ToString()+" Ogrencının Adını Soyadını Giriniz");
    
    adsoyad = Console.ReadLine();

    Console.WriteLine(sıralama.ToString() + " Ogrencinin vize notunu giriniz");
    decimal vize=Convert.ToDecimal(Console.ReadLine());
    if (vize<100&&vize>0)
    {
        vize = vize / 100 * 40;
    }

    else
    {
        Console.WriteLine("Yanlıs girdiniz");
    }


    Console.WriteLine(sıralama.ToString()+ " Ogrencinin final notunu giriniz");
    decimal final=Convert.ToDecimal(Console.ReadLine());
    if (final < 100 && final > 0)
    {
        final = final / 100 * 60;
        
    }

    else
    {
        Console.WriteLine("Yanlıs girdiniz");
    }
    ort =Convert.ToInt32( vize + final);

    if (ort >= 85 && ort <= 100)
    {
        harfNotu = "AA";
        Console.WriteLine(sıralama.ToString() + " Ogrencinin vize notunu " +ort.ToString()+"Harf Notu "+harfNotu);
        if (ort>enb)
        {
            enb = ort;
            enbadsoyad = adsoyad;
        }
        else if (ort<enk)
        {
            enk = ort;
            enkadsoyad = adsoyad;
        }
       
    }
    else if (ort >= 75 && ort <= 84)
    {
        harfNotu = "BA";
        Console.WriteLine(sıralama.ToString()+" Ogrencinin vize notunu " + ort.ToString() + "Harf Notu " + harfNotu);
        if (ort > enb)
        {
            enb = ort;
            enbadsoyad = adsoyad;
        }
        else if (ort < enk)
        {
            enk = ort;
            enkadsoyad = adsoyad;
        }
    }
    else if (ort >= 65 && ort <= 74)
    {
        harfNotu = "BB";
        Console.WriteLine(sıralama.ToString()+" Ogrencinin vize notunu " + ort.ToString() + "Harf Notu " + harfNotu);
        if (ort > enb)
        {
            enb = ort;
            enbadsoyad = adsoyad;
        }
        else if (ort < enk)
        {
            enk = ort;
            enkadsoyad = adsoyad;
        }
    }
    else if (ort >= 50 && ort <= 64)
    {
        harfNotu = "CC";
        Console.WriteLine(sıralama.ToString()+" Ogrencinin vize notunu " + ort.ToString() + "Harf Notu " + harfNotu);
        if (ort > enb)
        {
            enb = ort;
            enbadsoyad = adsoyad;
        }
        else if (ort < enk)
        {
            enk = ort;
            enkadsoyad = adsoyad;
        }
    }
    else if (ort >= 25 && ort <= 49)
    {
        harfNotu = "DC";
        Console.WriteLine(sıralama.ToString()+" Ogrencinin vize notunu " + ort.ToString() + "Harf Notu " + harfNotu);
        if (ort > enb)
        {
            enb = ort;
            enbadsoyad = adsoyad;
        }
        else if (ort < enk)
        {
            enk = ort;
            enkadsoyad = adsoyad;
        }
    }

    else
    {
        harfNotu = "FF";
        Console.WriteLine(sıralama.ToString()+" Ogrencinin vize notunu " + ort.ToString() + "Harf Notu " + harfNotu);
        if (ort > enb)
        {
            enb = ort;
            enbadsoyad = adsoyad;
        }
        else if (ort < enk)
        {
            enk = ort;
            enkadsoyad = adsoyad;
        }
    }
    
    orttoplam += ort;

    Console.WriteLine("");
    i++;
}

Console.WriteLine(enbadsoyad + " isimli ögrenci " + enb.ToString() + " Ortalama ile en yüksek ortalamaya sahip");
Console.WriteLine(enkadsoyad + " isimli ögrenci " + enk.ToString() + " Ortalama ile en düşük ortalamaya sahip");


genelorttoplam = orttoplam / n;

Console.WriteLine("Sınıfın Ortalaması "+genelorttoplam.ToString());
