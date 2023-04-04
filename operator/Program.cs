using System;
namespace operatorler{
    class Program{
        static void Main(){

            int x = 2;
            int y = 3;
            y=y+2;
            x=x+2;
            x*=2;

            // mantıksal operatorler
            // && || !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted){
                Console.WriteLine("Perfect");
            }

             if(isSuccess || isCompleted){
                Console.WriteLine("Great");
            }

             if(isSuccess && !isCompleted){
                Console.WriteLine("Great");
            }

            // ilişkisel operatörler
            // <,>,<=,>=,==,!=
            
            int a=3;
            int b=4;
            bool sonuc = a<b;

            sonuc = a>b;
            sonuc= a==b;
            sonuc=a>b;

            // aritmetik operatörler
            // *,+,-,/

            int sayi=10;
            int sayi2= 20;
            int sonuc1 = sayi/sayi2;
            
            // % mod almak için kullanılır
            sonuc1= sayi%sayi2;
            





        }
    }
}