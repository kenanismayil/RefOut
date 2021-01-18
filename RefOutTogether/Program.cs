using System;

namespace RefOutTogether
{
    class Program
    {
        static void Main(string[] args)
        {
            int refValue = 7;                              //baslangic degeri atamasi zorunludur.Cunki bu degeri ref parametresine gonderecegiz.
            int outValue = 17;                                  //baslangic deger atamasi zorunlu degil.
            int value = 9;

            Console.WriteLine("Before ChangeMethod function is called : " + value);
            Console.WriteLine("Before ChangeMethod function is called : " + refValue);
            Console.WriteLine("I don't need to write before ChangeMethod function is called.Because I didn't give value to outValue variable!");

            Console.WriteLine("---------------------------------------------------------------------");

            ChangeMetod(ref refValue, out outValue, value);

            Console.WriteLine("After ChangeMethod function is called : " + value);
            Console.WriteLine("After ChangeMethod function is called : " + refValue);
            Console.WriteLine("After ChangeMethod function is called : " + outValue);

            Console.ReadLine();
        }

        static void ChangeMetod(ref int x, out int y, int z)
        {
            z = z + 2;                                     //value degiskeninin orjinalini degil de kopyasini aldigi icin fonksiyon cagirildiktan sonra value'da bir degisiklik olmaz.
            x = x * 2;                                     //Burada x icin deger atamasi yapmak onemli degil.            
            y = 17;                                        //Fakat y argumani icin atama yapilmasi zorunludur.
        }
    }
    }
}
