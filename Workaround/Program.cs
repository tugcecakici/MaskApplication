

using Business.Concrete;
using Entities.Concrete;

SelamVer(isim : "Engin");
SelamVer(isim : "Ayşe");
SelamVer();
int sonuc = Topla(3, 5);

Person person1 = new Person();
person1.FirstName = "Engin";
person1.LastName = "Demiroğ";
person1.DateOfBirth = 1985;
person1.NationalIdentity = 123;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();


static void SelamVer(string isim = "İsimsiz") //default parametre değeri verdik.
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1 = 5 , int sayi2 = 10)
{
    int sonuc =  sayi1 + sayi2;  
    Console.WriteLine("Toplam: " + sonuc);
    return sonuc;
}
