using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TapsiriqC
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ExamPoint
            Boolean b = true;
            while (b)
            {
                try
                {
                    Console.WriteLine("eded daxil edin");
                    int ExamPoint = Convert.ToInt32(Console.ReadLine());

                    if (ExamPoint > 90 && ExamPoint <= 100)
                    {
                        Console.WriteLine("A");
                        b = false;
                    }
                    else if (ExamPoint > 80 && ExamPoint <= 90)
                    {
                        Console.WriteLine("B");
                        b = false;
                    }
                    else if (ExamPoint > 70 && ExamPoint <= 80)
                    {
                        Console.WriteLine("C");
                        b = false;
                    }
                    else if (ExamPoint > 60 && ExamPoint <= 70)
                    {
                        Console.WriteLine("D");
                        b = false;
                    }
                    else if (ExamPoint > 50 && ExamPoint <= 60)
                    {
                        Console.WriteLine("E");
                        b = false;
                    }
                    else if (ExamPoint < 50)
                    {
                        Console.WriteLine("kesildiniz");
                        b = false;
                    }
                    else
                    {
                        Console.WriteLine("zehmet olmasa 1 ile 100 arasi daxil edin:");
                        continue;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("xeta bas verdi zehmet olmasa duzgun daxil edin");
                }
            }
            Console.ReadKey();
            #endregion

            #region divide
            while (true)
            {
                Console.WriteLine("eded daxil edin");
                int divided = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= divided; i++)
                {
                    if (divided % i == 0)
                    {

                        Console.WriteLine("bolenler" + i);

                    }
                }
            }
            Console.ReadKey();

            #endregion

            #region ededin mertebeleri
            while (true)
            {
                Console.WriteLine("eded daxil edin");
                int floorNumber = Convert.ToInt32(Console.ReadLine());
                int result = 1;
                while (floorNumber > 9)
                {
                    floorNumber = floorNumber / 10;
                    result++;
                }
                Console.WriteLine("eded " + result + " mertebelidir");

            }
            Console.ReadKey();
            #endregion

            #region mertebe cemi
            while (true)
            {
                Console.WriteLine("eded daxil edin");
                int numberFloor = Convert.ToInt32(Console.ReadLine());
                int totalFloor = 0;
                while (numberFloor >= 1)
                {
                    totalFloor += numberFloor % 10;
                    numberFloor = numberFloor / 10;

                }
                Console.WriteLine(totalFloor);

            }
            Console.ReadKey();
            #endregion

            #region sadeMurekkeb
            //Boolean com()
            //{

            while (true)
                {
                    Console.WriteLine("eded daxil edin");
                    int numbers = Convert.ToInt32(Console.ReadLine());
                    int result = 0;
                    if (numbers != 1 && numbers != 2)
                    {
                        for (int i = 2; i < numbers; i++)
                        {

                            if (numbers % i == 0)
                            {
                                result++;
                                if (result >= 1)
                                {
                                    //return false;
                                    Console.WriteLine("murekkebdir");
                                    break;
                                }
                            }
                        }
                        if (result == 0)
                        Console.WriteLine("sadedir");
                    //return true;

                }
                    else
                    {
                        Console.WriteLine("ne sadedir ne murekkeb");

                    }

                }
                Console.ReadKey();
            //}

            #endregion

            #region faktorial
            Console.WriteLine("eded daxil edin");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("faktorial " + factorial);
            Console.ReadKey();
            #endregion

            #region fesiller
            while (true)
            {
                Console.WriteLine("1 ile 4 arasinda bir reqem daxil edin");
                int numb = Convert.ToInt32(Console.ReadLine());
                switch (numb)
                {
                    case 1:
                        Console.WriteLine("qis");
                        break;
                    case 2:
                        Console.WriteLine("yaz");
                        break;
                    case 3:
                        Console.WriteLine("yay");
                        break;
                    case 4:
                        Console.WriteLine("payiz");
                        break;

                    default:
                        Console.WriteLine("Zehmet olmasa duzgun daxil edin");
                        break;

                }

            }
            Console.ReadKey();
            #endregion

            #region boyukKicikCemi
            int[] arr = { 3, 5, 8, 1, 87, 150, 200, 250 };
            int little = arr[0];
            int big = big = arr[0];
            int total = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (little > arr[i])
                {
                    little = arr[i];
                }
                else if (big < arr[i])
                {
                    big = arr[i];
                }

            }
            Console.WriteLine("total= " + (big + little));

            Console.ReadKey();
            #endregion

            #region enUzunString
            string[] arr3 = { "ad", "soyad", "address", "yas", "qeydiyyatUnvani", "DogumTarixi" };

            string bigger = arr3[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (bigger.Length < arr3[i].Length)
                {
                    bigger = arr3[i];
                }
            }

            Console.WriteLine("en boyuk:" + big);
            Console.ReadKey();
            #endregion


            #region vumaCedveli
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(" "+i+"*" + j + "=" + (i * j));
       
                }
                Console.WriteLine();
            }
            Console.ReadKey();
#endregion
        }
    }

}