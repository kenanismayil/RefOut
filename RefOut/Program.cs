using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref ve out parametreleri

            int aa = 10;                     //deger atamasi yapilmasa ref parametresi calismaz.Cunki aa'dan deger almasi lazim ki
                                             //ParamRef'te degisiklik yapabilsin.Bu static void Param(int x) icin de gecerlidir.
                                             //out parametresi calismasi icin aa'ya baslangic degeri vermek zorunda degiliz.Deger
                                             //versek de vermesek de bu programda ParamOut 2 olacaktir.

            Console.WriteLine("Param metodu gelmeden once : " + aa);

            Param(aa);
            Console.WriteLine("Param metodu geldikten sonra : " + aa);

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("ParamRef metodu gelmeden once : " + aa);
            ParamRef(ref aa);                //ParamRef cagrimi şöyle yapilir.
            Console.WriteLine("ParamRef metodu geldikten sonra : " + aa);


            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("ParamOut metodu gelmeden once : " + aa);
            ParamOut(out aa);                //ParamRef cagrimi şöyle yapilir.
            Console.WriteLine("ParamOut metodu geldikten sonra : " + aa);


            Console.ReadLine();
        }
        static void Param(int x)            //aa'nin bellek adresini degil de degerini kopyalar.
        {
            x = x * 2;                      //degerini kopyaladigi icin aa'nin icerigini degisemez ve aa once de sonra da ayni kalir.
        }

        static void ParamRef(ref int x)     //aa'nin bellek adresini x degiskenine ref parametresiyle kopyalar. 
        {
            x = x * 2;                      //x dogrudan aa'nin adresine gider ve degeri 20 yapar.
        }

        static void ParamOut(out int x)
        {
            x = 2;                         //Diger parametrelerden farkli olarak out parametresinde metot icinde atama islemi yapilmalidir.Yoksa
        }                                  //program calismaz,aa degeri x'e gelmez.
    }
    }
}
