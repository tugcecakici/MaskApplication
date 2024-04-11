// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Person person = new Person(); //Person class'ı public yapıldı, "add reference to entities" --> bu sayede kullanabildik.

//Void metotlar sadece işi yapar. Herhangi bir döngü döndürmez."Git bunu kaydet, git bunu sil" gibi. Hesap yap, değer ver gibi işlemler için return 

static void degiskenler()
{
string mesaj = "Selam"; // string : metinsel değişken.
Console.WriteLine(mesaj);

double tutar = 100.50;
Console.WriteLine(tutar * 1.18);

int sayi = 0;
bool girisYapmisMi = false;

//mantıksal bir grup oluşturmak için nesne oluşturulur = class.
}

//pascal casing
public class Vatandas
{
    //public string ad = "Engin"; //bu değişkenlerin başına public koymazsak başka classlarda kullanamayız.
    //public string soyad = "Demiroğ";
    //public int dogumYili = 1995;
    //public long tcNo = 11111111111;

    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}