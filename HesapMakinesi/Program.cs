// Girilen iki sayı için 4 işlem programını yapınız.(iki sayı girilecek seçim +,-, / , * olacak.Sadece Switch-Case kullanılacak.)
using System.ComponentModel.Design;

double sayi1, sayi2;
Console.Write("1.sayıyı giriniz:");
sayi1 = double.Parse(Console.ReadLine());
sayi2: Console.Write("2.sayıyı giriniz:");
sayi2 = double.Parse(Console.ReadLine());
islem: Console.WriteLine("İşlem yapmak istediğiniz operatörü seçiniz: \n Toplama için '+', Çıkarma için '-', Çarpma için '*', Bölme için '/'");
char islem = char.Parse(Console.ReadLine());
switch (islem)
{
    case '+':
        Console.WriteLine($"Yaptırmak istediğiniz işlemin sonucu: {sayi1 + sayi2}");
        break;
    case '-':
        Console.WriteLine($"Yaptırmak istediğiniz işlemin sonucu: {sayi1 - sayi2}");
        break;
    case '*':
        Console.WriteLine($"Yaptırmak istediğiniz işlemin sonucu: {sayi1 * sayi2}");
        break;
    case '/':
        switch (sayi2)
        {
            case 0:
                Console.WriteLine("Bölme işlemi yaptırmak istiyorsanız 2.sayıyı 0'dan farklı girmelisiniz!");
                goto sayi2;
                break;
            default:
                Console.WriteLine($"Yaptırmak istediğiniz işlemin sonucu: {sayi1 / sayi2}");
                break;
        }
        break;
    default:
        Console.WriteLine("Lütfen geçerli bir operatör giriniz.");
        goto islem;
        break;
}
Console.ReadLine();
