using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_06._21._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] massiv1 = { 1, 5, 15, 2 };
            int[] massiv2 = { 2, 3, 20, 1 };
            //Console.WriteLine(Compare(massiv1,massiv2));


            int mult = 15;
            int[] multiple = { 15, 30, 75 };
            ///<summary>
            ///Console.WriteLine(MyMult(mult,multiple));
            ///Sebeb bu bir foreach-dir ferqi yoxdur for da ola biler 
            ///onun indeks elementlerini consola vermek ucun biz bir fordan istifade etmeliyik
            /// </summary>


            int[] mustAdinBeAray = MyMult(mult, multiple);
            foreach (int item in mustAdinBeAray)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Ev TTapsirigi Baslayacaq");

            // Ev Tapsirigi 1 begin
            int[] Advertage = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Console.WriteLine(Advertage_Number(Advertage));//with for 
            Console.WriteLine(Advertage_Number_foreach(Advertage));//with foreach
            // Ev Tapsirigi 1 end

            //Ev Tapsirigi 2 Begin
            string mytrim = "Insan Sevdiklerini uzerinde qelebe qazana bilmez";
            Console.WriteLine(countSpaces(mytrim));// for
            Console.WriteLine(countSpacesForeach(mytrim));//foreach
            //Ev Tapsirigi 2 end

            //Ev Tapsirigi 3 Begin
            string letters = "Kamran";
            //Console.WriteLine(countSimvol(letters));
             countSimvol("Kamran");
            //Ev Tapsirigi 3 end

            //Ev tapsirig 4 Begin
            string reverse = "Tutu topu tut";
            //Console.WriteLine(reverse);
            Console.WriteLine(reverseLetter(reverse)); // with for /foreach ile yazilmir.
            StringBuilder insBuild = reverseLetterB(reverse);//StringBuilder
            Console.WriteLine(insBuild);
            //Ev tapsirig 4 end 

            Console.Read();
        }

        static string Compare(int[] lab1, int[] lab2)
        {
            //return "";
            string myresult = "";
            if (lab1.Length == lab2.Length)
            {

                int count1 = 0;
                int count2 = 0;

                for (int i = 0; i < lab1.Length; i++)
                {
                    if (lab1[i] > lab1[i])
                    {
                        count1++;
                    }
                    else if (lab1[i] > lab1[i])
                    {

                        count2++;
                    }
                    else
                    {
                        count1++;
                        count2++;
                    }
                }

                if (count1 > count2)
                {
                    myresult = "Birinci Komanda uddu";

                }
                else if (count1 < count2)
                {
                    myresult = "Ikinci Komanda uddu";
                }
                else
                {
                    myresult = "Her iki Komanda beraberdir";
                }
            }
            return myresult;

        }
        //Lab 
        static int[] MyMult(int num, int[] arrayNum)
        {
            int[] result = new int[arrayNum.Length];
            #region demo
            // foreach (var item in arrayNum)
            //  {
            //  result[item] = arrayNum[item] * num;
            // }islemedi bele yazmaga cehd eleme
            #endregion

            for (int i = 0; i < arrayNum.Length; i++)
            {
                result[i] = arrayNum[i] * num;
            }
            return result;
        }

        static int Advertage_Number(int[] arraymy) //with for 
        {
            int counter = 0; int div = arraymy.Length;
            for (int i = 0; i < arraymy.Length; i++)
            {
                counter += arraymy[i];

            }

            return counter / div;
        }

        //Ev Tapsirigi Baslayir
        static int Advertage_Number_foreach(int[] foreach_array) //with foreach
        {
            int count = 0; int div_foreach = foreach_array.Length;

            foreach (var item in foreach_array)
            {
                count += item;
            }
            return count / div_foreach;
        }


        static int countSpaces(string mystr)//with for 
        {
             int count = 0;
            for (int i = 0; i < mystr.Length; i++)
            {
                if (mystr[i] == ' ')
                {
                    count++;
                }
            }
            return count;

        } 


        static int countSpacesForeach(string strmy)//with foreach
        {
            int count = 0;
            foreach (int item in strmy)
            {
                if (item == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        static void countSimvol(string strsimvol)//with for 
        {
            string result = "";

            for (int i = 0; i < strsimvol.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < strsimvol.Length; j++)
                {
                    if (strsimvol[i] == strsimvol[j])
                    {
                        count++;
                    }
                }

                //result += strsimvol[i] + count + "eded";
                Console.WriteLine($"{strsimvol[i]}  : {count} eded");
            }
            //return result;
        }
  

        static string reverseLetter(string revstr)//with for 
        {
            string revcontent = "";
            int count = revstr.Length;

            for (int i = count-1; i > 0; i--)
            {
              
                
                revcontent += revstr[i];
            }

            return revcontent;
        }

        static StringBuilder reverseLetterB(string revstr)//with reverseLetterB with for 
        {
            StringBuilder revcontent = new StringBuilder();
           // string revcontent = "";
            int count = revstr.Length;

            for (int i = count - 1; i > 0; i--)
            {


                revcontent.Append(revstr[i]);
            }

            return revcontent;
        }
            





    }
}

