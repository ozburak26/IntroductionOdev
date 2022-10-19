



// See https://aka.ms/new-console-template for more information

//for (int i = 2020;  i >= 2000; i--)
//{
//    Console.Write(""+i--+" ");

//}



//Console.WriteLine("Hangi Mesajı yazalım ?");
//string msj=Console.ReadLine();

//Console.WriteLine("Kaç defa yazılsın?");

//int adet=Convert.ToInt32(  Console.ReadLine());

//for (int i = 0; i < adet; i++)
//{

//    Console.WriteLine(msj);

//}

//Console.WriteLine("------");

//int j = 0;
//while (j < adet)
//{
//    Console.WriteLine   (msj);
//    j++;
//}

//Console.WriteLine("Kaç adet sayı gireceksiniz?");

//int n=Convert.ToInt32(Console.ReadLine());

//int enb=int.MinValue;

//for (int i = 0; i < n; i++)
//{

//    Console.WriteLine(i+"Sayıyı Gir");

//    int sayi=Convert.ToInt32(Console.ReadLine());
//    if (sayi >enb)
//    {
//        enb=sayi;

////    }

////}

//int k = 0;

//int enk = int.MaxValue;


//while (k <n)
//{
//    k++;
//    Console.WriteLine(k+"  Sayıyı girin");
//    int  sayi=Convert.ToInt32((Console.ReadLine()));
//    if (sayi < enk)
//    {
//        enk=sayi; ;
//    }


//}
//Console.WriteLine("En kucuk Sayı" + enk.ToString());

//Console.WriteLine("En buyuk Sayı"+enb.ToString());

string cevap;
do
{

    Console.WriteLine("Lütfen bir  msj giriniz");
    string  msj=Console.ReadLine();
    Console.WriteLine(msj);
    Console.WriteLine("Tekrar msj  girrmek istermisiniz");

    cevap=Console.ReadLine();



} while (cevap.ToLower()=="evet");