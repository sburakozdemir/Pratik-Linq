# LINQ Pratik Örneği

Bu proje, C# ve LINQ kullanarak çeşitli liste işlemlerini gerçekleştiren basit bir konsol uygulamasıdır. Rastgele sayılardan oluşan bir liste üzerinde farklı LINQ sorgularını uygulayarak, LINQ'in temel özelliklerini gösterir.

## Özellikler

- Rastgele 10 adet sayı oluşturma
- Çift sayıları filtreleme
- Tek sayıları filtreleme
- Negatif sayıları filtreleme
- Pozitif sayıları filtreleme
- 15'ten büyük ve 22'den küçük sayıları filtreleme
- Her sayının karesini hesaplama

## Gereksinimler

- .NET 5.0 veya üzeri

## Kullanım

1. Projeyi klonlayın:
   ```
   git clone https://github.com/kullaniciadi/linq-pratik-ornegi.git
   ```
2. Proje dizinine gidin:
   ```
   cd linq-pratik-ornegi
   ```
3. Uygulamayı çalıştırın:
   ```
   dotnet run
   ```

## Kod Örneği

İşte projenin ana mantığını gösteren bir kod parçası:

```csharp
List<int> sayilar = Enumerable.Range(0, 10).Select(_ => rnd.Next(-100, 100)).ToList();

var ciftSayilar = sayilar.Where(x => x % 2 == 0);
var tekSayilar = sayilar.Where(x => x % 2 != 0);
var negatifSayilar = sayilar.Where(x => x < 0);
var pozitifSayilar = sayilar.Where(x => x > 0);
var ozelSayilar = sayilar.Where(x => x > 15 && x < 22);
var kare = sayilar.Select(x => x * x);
```
