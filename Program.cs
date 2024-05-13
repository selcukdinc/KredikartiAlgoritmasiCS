
namespace KrediKartıAlgoritması_C__;

class Program
{
    static void Main(string[] args)
    {
        // KREDi KARTI DOĞRULAMA (LUHN ALGORİTMASI)
        // LUHN ALGORiTMASI NEDiR?
        // Alman asıllı bir Bilgisayar Bilimcisi olan Hans Peter Luhn ve IBM tarafından 1954 yılında geliştirilen 
        // ve günümüzde halen tüm kredi kartlarında kullanılan doğrulama algoritmasıdır. 
        // Luhn algoritması, kredi kartlar üzerinde 16 hane ile belirtilmiş olan kart numaralarında, 
        // her bir hanenin arasında belli bir aritmetik kurmayı sağlamıştır. 
        // Aynı zamanda bu algoritma bazı kaynaklarda Luhn Check ve Mod Check isimleriyle geçmektedir.
        // 
        //  16 haneli bir kredi kartı numarasında ilk hanenin indisi 0 ve son hanenin indisi 15 olmak üzere algoritmayı aşağıdaki gibi ele alabiliriz:
        //  1. Çift indisli hanelerin iki katını al. çıkan sonucun basamaklarını topla ve bir değişkende tut (ciftToplam).
        //  2. Tek indisli hanelerin toplamını bir başka degiskende tut (tekToplam).
        //  3. ciftToplam+tekToplam işleminin sonucundaki say eğer 10 ile tam bölünebiliyorsa, girilen numara doğrudur.
        Console.Clear();
        int CiftToplam = 0, TekToplam = 0, say, sayac = 0;
        Console.Write("-- Kredi Kartı Numaranız Gerçek mi ? --\n\t16 Haneli Numara\n: ");
        // Sayının doğruluğunun pas geçiyorum
        // tipi x olan dizinin elemanlarını kontrol etmem gerekiyor, char mı string mi?
                // string Deneme1 = Console.ReadLine();
                // Console.Write("{0}",Deneme1[1]);   // 123 girdisinde 2 sonucunu verdi 
        
        string KartNum = Console.ReadLine();
        foreach (char karakter in KartNum)
        {
            int sayi = Convert.ToInt32(karakter.ToString());
            if (sayac % 2 == 0)
            {
                int sonuc = 0, Temp = sayi * 2;
                if (Temp / 10 == 1) sonuc = (Temp % 10) + 1;
                else sonuc = Temp;
                CiftToplam += sonuc;
            }else
            {
                TekToplam += sayi;
            }
            sayac++;
        }
        say = CiftToplam + TekToplam;
        if (say % 10 == 0)  Console.Write("Bu kartınız gerçek! :) ");
            else            Console.Write("Bu kartınız gerçek değil !!! >:( ");
        Console.ReadKey();
    }
}
