// See https://aka.ms/new-console-template for more information
int hak = 3;
string durum = null;
string username=null;
string password=null;   

for (int i = 0; i < hak; )
{
    Console.WriteLine("Kullanıcı adını giriniz");
    username = Console.ReadLine();
    Console.WriteLine("Parola Giriniz");
    password = Console.ReadLine();

    if (username == "admin" && password == "123")
    {

        i = 4;
        durum = "basarılı";
    }
    else
    {

        int kalan = hak - i - 1;
        Console.WriteLine(Convert.ToInt32(kalan)+" hakkınız kaldı");

        i++;
    }

}
if (durum=="basarılı")
{
    Console.WriteLine   ("Hoşgeldiniz");

}
else
{
    Console.WriteLine("Hakkınız kalmamıştır.");
}
