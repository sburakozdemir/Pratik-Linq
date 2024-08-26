using System;
using System.Collections.Generic;
using System.Linq;
// Rastgele sayı üreteci oluştur
Random rnd = new Random();

// 10 adet rastgele sayı içeren bir liste oluştur
// Sayılar -100 ile 99 arasında olacak (100 dahil değil)
List<int> sayilar = Enumerable.Range(0, 10).Select(_ => rnd.Next(-100, 100)).ToList();

// Tüm sayıları yazdır
Console.WriteLine("Tüm sayılar:");
Console.WriteLine(string.Join(", ", sayilar));

// Çift sayıları filtrele ve yazdır
Console.WriteLine("\nÇift sayılar:");
var ciftSayilar = sayilar.Where(x => x % 2 == 0);
Console.WriteLine(string.Join(", ", ciftSayilar));

// Tek sayıları filtrele ve yazdır
Console.WriteLine("\nTek sayılar:");
var tekSayilar = sayilar.Where(x => x % 2 != 0);
Console.WriteLine(string.Join(", ", tekSayilar));

// Negatif sayıları filtrele ve yazdır
Console.WriteLine("\nNegatif Sayılar:");
var negatifSayilar = sayilar.Where(x => x < 0);
Console.WriteLine(string.Join(", ", negatifSayilar));

// Pozitif sayıları filtrele ve yazdır
Console.WriteLine("\nPozitif Sayılar:");
var pozitifSayilar = sayilar.Where(x => x > 0);
Console.WriteLine(string.Join(", ", pozitifSayilar));

// 15'ten büyük ve 22'den küçük sayıları filtrele ve yazdır
Console.WriteLine("\n15'ten büyük ve 22'den küçük sayılar:");
var ozelSayilar = sayilar.Where(x => x > 15 && x < 22);
Console.WriteLine(string.Join(", ", ozelSayilar));

// Her sayının karesini hesapla ve yazdır
Console.WriteLine("\nListenin karesi:");
var kare = sayilar.Select(x => x * x);
Console.WriteLine(string.Join(", ", kare));