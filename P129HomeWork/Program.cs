using System;

namespace P129HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Home Work - 1
            //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod - 3 integer parametr qebul edir ve
            //iclerinde en boyuk hansidirsa onu tapib return edir Eyni sekilde verilmis 4 ve 5 ededin
            //en boyuyunu tapan metodlar da yazin (method overloading)

            int x = 14;
            int y = 19;
            int z = 26;
            int k = 88;
            int m = 43;

            Console.WriteLine(Biggerone(x, y, z,k,m));



            #endregion

            #region Home Work - 2
            //Gonderilmis ededin reqemlerinin cemini qaytaran metod - misalcun bu metodu call
            //ederken arqument olaraq 451 gondersek metoddan geriye 10 qayitmalidir
            #endregion

            #region Home Work - 3
            //Supermarketdə belə bir aksiya keçirilir: “İstənilən iki mal alana üçüncüsü pulsuz verilir,
            //ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”.Alınacaq 3 məhsulun qiyməti
            //verilmişdirsə ödəniləcək məbləği hesbalayan metod yazin - yəni metodunuz 3 doubel parameter
            //qebul edib en boyuk ikisinin cemini hesablayib qaytarmalidir
            #endregion
            Console.WriteLine(Cheeper(5, 8, 8));
        }

        #region Home Work - 1
        //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod - 3 integer parametr qebul edir ve
        //iclerinde en boyuk hansidirsa onu tapib return edir Eyni sekilde verilmis 4 ve 5 ededin
        //en boyuyunu tapan metodlar da yazin (method overloading)

        static int Biggerone(int a, int b,int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > c && b > a)
                return b;
            else
                return c;        
        }

        static int Biggerone(int a, int b, int c, int d)
        {
            return Biggerone(a, b, c) > d ? Biggerone(a, b, c) : d;            
        }

        static int Biggerone(int a, int b, int c, int d,int e)
        {
            return Biggerone(a,b,c,d) > e ? Biggerone(a, b, c,d) : e;
        }



        #endregion

        #region Home Work - 2
        //Gonderilmis ededin reqemlerinin cemini qaytaran metod - misalcun bu metodu call
        //ederken arqument olaraq 451 gondersek metoddan geriye 10 qayitmalidir
        static int Ededcemi (int a)
        {
            int count;
            int cem = 0;
            while ( a > 0)
            {
                count = a % 10;
                a = (a - count) / 10;
                cem += count;
            }
            return cem;
        }

        #endregion

        #region Home Work - 3
        //Supermarketdə belə bir aksiya keçirilir: “İstənilən iki mal alana üçüncüsü pulsuz verilir,
        //ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”.Alınacaq 3 məhsulun qiyməti
        //verilmişdirsə ödəniləcək məbləği hesbalayan metod yazin - yəni metodunuz 3 doubel parameter
        //qebul edib en boyuk ikisinin cemini hesablayib qaytarmalidir
        static double Cheeper (double a , double b, double c)
        {
            if (a <=b && a <= c)
            {

                return b + c;
            }
            else if (b <= a && b <= c)
            {

                return a + c;
            }
            else return a + b;

          
            






        }
        #endregion
    }
}
