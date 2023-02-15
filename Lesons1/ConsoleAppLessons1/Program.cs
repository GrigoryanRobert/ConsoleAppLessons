using System.Runtime.CompilerServices;

namespace ConsoleAppLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 3;
            //int b = 4;
            //if (a > b)
            //{
            //    Console.WriteLine("A big than B");
            //}
            //else
            //{
            //    Console.WriteLine("B big than A");
            //}

            //Console.WriteLine(a > b ? "A big than B" : "B big than A");

            //21.kartacen a,b,c tveric meci arjeq
            int maxInt = bigNumber(4, 15, 15);
            Console.Write("a,b,c tveric meci arjeq:");
            Console.WriteLine(maxInt);
            //22.kartacen a,b,c tveric poqri arjeq
            int minInt = minNumber(100, 7, 15);
            Console.Write("a,b,c tveric poqri arjeq:");
            Console.WriteLine(minInt);
            //23.kartacen true ,ete a,b,c tveric mek havasar  mekin
            bool oneEqualNum = oneEqual(18, 7, 15);
            Console.Write("a,b,c tveric mek havasar  mekin:");
            Console.WriteLine(oneEqualNum);
            //24.kartacen true ,ete a,b,c tveric 2 havasar e 2
            bool twoEqualTwoNum = twoEqualTwo(2, 7, 2);
            Console.Write("a,b,c tveric 2 havasar e 2:");
            Console.WriteLine(twoEqualTwoNum);
            //25.kartacen "y=1" ,ete a,b,c tveric hnaravor lini erankuni karucel, hakarak depqum "y=2"
            string threeAngelNum = threeAngel(5, 3, 4);
            Console.Write("kartacen \"y=1\" ,ete a,b,c tveric hnaravor lini erankuni karucel, hakarak depqum \"y=2\":");
            Console.WriteLine(threeAngelNum);
            //26.kartacen 1, ete trvac tveric mek zuyg e
            int oneEvenNum = oneEven(55, 7, 9);
            Console.Write("kartacen 1, ete trvac tveric mek zuyg e:");
            Console.WriteLine(oneEvenNum);
            //27.kartacen true, ete trvac tver tvabanakan progresia en
            bool numberProgresNum = numberProgres(2, 5, 8);
            Console.Write("kartacen true, ete trvac tver tvabanakan progresia en:");
            Console.WriteLine(numberProgresNum);
            //28.kartacen true, ete trvac tver tvabanakan progresia en
            bool numberGeometricProgresNum = numberGeometricProgres(8, 4, 2);
            Console.Write("kartacen true, ete trvac tver erkrachapakan progresia en:");
            Console.WriteLine(numberGeometricProgresNum);
            //29.kartacen achman kargi 
            int[] numAsortNum = numAsort(7, 15, 8);
            Console.Write("kartacen achman kargi:");
            Console.WriteLine(String.Join(",", numAsortNum));

            //30.kartacen achman kargi 
            int[] numRsortNum = numRsort(7, 15, 8);
            Console.Write("kartacen nvazman kargi:");
            Console.WriteLine(String.Join(",", numRsortNum));

            //31.kartacen a,b,c,d tveric meci arjeq
            int maxIntFour = bigNumber(4, 15, 15, 85);
            Console.Write("a,b,c,d tveric meci arjeq:");
            Console.WriteLine(maxIntFour);
            //32.kartacen a,b,c tveric poqri arjeq
            int minIntFour = minNumber(100, 7, 15, 1);
            Console.Write("a,b,c,d tveric poqri arjeq:");
            Console.WriteLine(minIntFour);
            //33.kartacen true,ete a,b,c,d tveric mek =1
            bool getOne = numberGetOne(100, 7, 15, 1);
            Console.Write("a,b,c,d tveric mek = 1:");
            Console.WriteLine(getOne);
            //34.kartacen true,ete a,b,c,d tveric erkusi gumar = mius erkusi gumarin
            bool twoNumbersSumEqualNum = twoNumbersSumEqual(100, 7, 80, 27);
            Console.Write("kartacen true,ete a,b,c,d tveric erkusi gumar = mius erkusi gumarin:");
            Console.WriteLine(twoNumbersSumEqualNum);
            //35.kartacen true,ete a,b,c,d tveric 1 gumar = mius ereqi gumarin
            bool oneNumbersSumOthersEqualNum = oneNumbersSumOthersEqual(100, 10, 80, 10);
            Console.Write("kartacen true,ete a,b,c,d tveric 1 gumar = mius ereqi gumarin:");
            Console.WriteLine(oneNumbersSumOthersEqualNum);
            //36.kartacen 1,ete a,b,c,d tveric gone 2 kent en , hakarak depqum 2
            int twoIsOvnNum = twoIsOvn(9, 10, 11, 10);
            Console.Write("kartacen 1,ete a,b,c,d tveric 2 kent en, hakarak depqum 2:");
            Console.WriteLine(twoIsOvnNum);

            //51.eranish tvi miavor=har+tas return tru, else false
            bool sumTwoOneNum = sumTwoOne(559);
            Console.Write("eranish tvi miavor=har+tas return tru, else false:");
            Console.WriteLine(sumTwoOneNum);

            //52.eranish tvi miavorneri mej kan havasar tver return tru, else false
            bool eranishTviMiavorHavasarNum = eranishTviMiavorHavasar(559);
            Console.Write("eranish tvi miavorneri mej kan havasar tver return tru, else false:");
            Console.WriteLine(eranishTviMiavorHavasarNum);

            //53.eranish tvi ev ir tvanshanneri haraberutyun, ete eranish tiv>k, else hakarak
            double eranishTviHarabValNum = eranishTviHarabVal(559);
            Console.Write("eranish tvi ev ir tvanshanneri haraberutyun, ete eranish tiv>k, else hakarak:");
            Console.WriteLine(eranishTviHarabValNum);

            //54.gtnel eranishi tveric mecn
            int eranishMecTivNum = eranishMecTiv(559);
            Console.Write("gtnel eranishi tveric mecn:");
            Console.WriteLine(eranishMecTivNum);

            //55.gtnel eranishi tveric poqr
            int eranishTivPoqrNum = eranishTivPoqr(559);
            Console.Write("gtnel eranishi tveric poqr:");
            Console.WriteLine(eranishTivPoqrNum);

            //56.gtnel eranish Tvi Miavor Mec Tasnavor
            double eranishTviMiavorMecTasNum = eranishTviMiavorMecTas(637);
            Console.Write("gtnel eranishi Tvi Miavor Mec Tasnavor:");
            Console.WriteLine(eranishTviMiavorMecTasNum);

            //57. eranish Tiv>300,return tas/miavor,else har/miav 
            double eranishMecEreqharyurNum = eranishMecEreqharyur(637);
            Console.Write("eranish Tiv>300,return tas/miavor,else har/miav :");
            Console.WriteLine(eranishMecEreqharyurNum);

            //58.ete eranish tvi tasnavori ev haryuravori gumar ec e 5, veradardznel 'a', hakarak depqum 'b'
            simbolF(125);

            //59eranish Tiv Achman Kargi
            int[] eranishTivAchmanKargi = eranishAchmanKargi(487);
            Console.Write("eranish Tiv Achman Kargi :");
            Console.WriteLine(String.Join(",", eranishTivAchmanKargi));
            //60eranish Tiv Nvazman Kargi
            int[] eranishTivNvazmanKargi = eranishNvazmanKargi(487);
            Console.Write("eranish Tiv Nvazman Kargi :");
            Console.WriteLine(String.Join(",", eranishTivNvazmanKargi));

            //61qaranish Tiv miav+tas = haz+har
            bool miavorTasHavHarHazNum = miavorTasHavHarHaz(4875);
            Console.Write("qaranish Tiv miav+tas = haz+har:");
            Console.WriteLine(miavorTasHavHarHazNum);

            //62qaranish Tiv poqr e 5000, a/ miav+har,else a/ haz+tas
            double qaranishTviHaraberutyunNum = qaranishTviHaraberutyun(4875);
            Console.Write("qaranish Tiv poqr e 5000, a/ miav+har,else a/ haz+tas:");
            Console.WriteLine(qaranishTviHaraberutyunNum);

            //63qaranish Tivparunakum e 1
            int getOneInQaranishNum = getOneInQaranish(4871);
            Console.Write("qaranish Tiv parunakum e 1:");
            Console.WriteLine(getOneInQaranishNum); 
            
            //64 qaranish Tiv miav+tas<5, y="s", else y="d"
            string qaranishMGumNum = qaranishMGum(4831);
            Console.Write("qaranish Tiv miav+tas<5, y=\"s\", else y=\"d\":");
            Console.WriteLine(qaranishMGumNum);
            //65 aranish Tiv miav*tas=12, y=1, else y=0
            string qaranishMTArtadryalNum = qaranishMTArtadryal(4834);
            Console.Write("qaranish Tiv miav*tas=12, y=1, else y=0:");
            Console.WriteLine(qaranishMTArtadryalNum);
            
            //66 qaranish Tiv arajin kam verjin nish 4
            string qaranishFirstLastGetForNum = qaranishFirstLastGetFor(4833);
            Console.Write("qaranish Tiv arajin kam verjin nish 4:");
            Console.WriteLine(qaranishFirstLastGetForNum);

            //67 qaranish tvi miavorner gumari qarakusin 
            string qarIrTGumQarakusiNum = qarIrTGumQarakusi(4833);
            Console.Write("qaranish tvi miavorner gumari qarakusin havasar e qaranish tvin:");
            Console.WriteLine(qarIrTGumQarakusiNum);

        }

        /// <summary>
        /// //21.kartacen a,b,c tveric meci arjeq@
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int bigNumber(int a, int b, int c)
        {
            int[] arrayInt = new int[3];
            arrayInt[0] = a;
            arrayInt[1] = b;
            arrayInt[2] = c;

            int maxInt = arrayInt[0];

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] > maxInt)
                {
                    maxInt = arrayInt[i];
                }
            }

            return maxInt;
        }
        //31
        public static int bigNumber(int a, int b, int c, int d)
        {
            int[] arrayInt = new int[4];
            arrayInt[0] = a;
            arrayInt[1] = b;
            arrayInt[2] = c;
            arrayInt[3] = d;

            int maxInt = arrayInt[0];

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] > maxInt)
                {
                    maxInt = arrayInt[i];
                }
            }

            return maxInt;
        }
        /// <summary>
        /// //21.kartacen a,b,c tveric poqri arjeq@
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int minNumber(int a, int b, int c)
        {
            int[] arrayInt = new int[3];
            arrayInt[0] = a;
            arrayInt[1] = b;
            arrayInt[2] = c;

            int minInt = arrayInt[0];

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] < minInt)
                {
                    minInt = arrayInt[i];
                }
            }

            return minInt;
        }
        //32
        public static int minNumber(int a, int b, int c, int d)
        {
            int[] arrayInt = new int[4];
            arrayInt[0] = a;
            arrayInt[1] = b;
            arrayInt[2] = c;
            arrayInt[3] = d;

            int minInt = arrayInt[0];

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] < minInt)
                {
                    minInt = arrayInt[i];
                }
            }

            return minInt;
        }
        /// <summary>
        /// //23.kartacen true ,ete a,b,c tveric mek havasar 1 mekin
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>true or false</returns>
        public static bool oneEqual(int a, int b, int c)
        {
            int[] arrayInt = new int[3];
            arrayInt[0] = a;
            arrayInt[1] = b;
            arrayInt[2] = c;

            int firstInt= arrayInt[0];

            for (int i = 1; i < arrayInt.Length; i++)
            {
                if (firstInt == arrayInt[i])
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>true or false</returns>
        public static bool twoEqualTwo(int a, int b, int c)
        {
            if (a == b && a == 2)
            {
                return true;
            }
            if (a == c && a == 2)
            {
                return true;
            }
            if (b == c && b == 2)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string threeAngel(int a, int b, int c)
        {
            if (a * a == (b * b + c * c))
            {
                return "y=1";
            }
            if (b * b == (a * a + c * c))
            {
                return "y=1";
            }
            if (c * c == (a * a + b * b))
            {
                return "y=1";
            }

            return "y=2";
        }
        /// <summary>
        /// kartacen 1, ete trvac tveric mek zuyg e
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int oneEven(int a, int b, int c)
        {
            int[] arrayInt = new int[3];
            arrayInt[0] = a;
            arrayInt[1] = b;
            arrayInt[2] = c;

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] % 2 == 0)
                {
                    return 1;
                }
            }

            return 2;
        }

        /// <summary>
        /// kartacen true, ete trvac tver tvabanakan progresia en
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool numberProgres(int a, int b, int c)
        {
            int d = b - a;
            if (c == a + 2d)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// kartacen true, ete trvac tver erkrachapakan progresia en
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool numberGeometricProgres(int a, int b, int c)
        {
            float q = (float)b / (float)a;
            if ((float)c == (float)(a * q * q))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// kartacen achman kargi 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns> array with Asort</returns>
        public static int[] numAsort(int a, int b, int c)
        {
            int[] arrayInt = new int[3];
            arrayInt[0] = a;
            arrayInt[1] = b;
            arrayInt[2] = c;
            int t;

            for (int i = 0; i < arrayInt.Length - 1; i++)
            {
                int test = arrayInt[i];
                for (int j = i + 1; j < arrayInt.Length; j++)
                {
                    if (arrayInt[i] > arrayInt[j])
                    {
                        t = arrayInt[i];
                        arrayInt[i] = arrayInt[j];
                        arrayInt[j] = t;
                    }
                }

            }
            return arrayInt;
        }
        /// <summary>
        /// kartacen nvazman kargi 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>array rsort</returns>
        public static int[] numRsort(int a, int b, int c)
        {
            int[] arrayInt = new int[3];
            arrayInt[0] = a;
            arrayInt[1] = b;
            arrayInt[2] = c;
            int t;

            for (int i = 0; i < arrayInt.Length - 1; i++)
            {
                int test = arrayInt[i];
                for (int j = i + 1; j < arrayInt.Length; j++)
                {
                    if (arrayInt[i] < arrayInt[j])
                    {
                        t = arrayInt[i];
                        arrayInt[i] = arrayInt[j];
                        arrayInt[j] = t;
                    }
                }

            }
            return arrayInt;
        }

        /// <summary>
        /// kartacen true, ete trvac tveric mek havasar e 1
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool numberGetOne(int a, int b, int c, int d)
        {
            int[] arrayInt = new int[4];
            arrayInt[0] = a;
            arrayInt[1] = b;
            arrayInt[2] = c;
            arrayInt[3] = d;
            bool numberBool = false;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] == 1)
                    numberBool = true;
            }
            return numberBool;
        }

        /// <summary>
        /// a,b,c,d tveric erkusi gumar = mius erkusi gumarin
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns>true or false</returns>
        public static bool twoNumbersSumEqual(int a, int b, int c, int d)
        {
            if (a + b == c + d || a + c == b + d || a + d == c + b)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// kartacen true,ete a,b,c,d tveric 1 gumar = mius ereqi gumarin
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool oneNumbersSumOthersEqual(int a, int b, int c, int d)
        {
            if (a == b + c + d || b == a + c + d || c == a + b + d || d == a + b + c)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// kartacen 1,ete a,b,c,d tveric gone 2 kent en , hakarak depqum 2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int twoIsOvn(int a, int b, int c, int d)
        {
            int count = 0;
            if (a % 2 != 0)
            {
                count++;
            }
            if (b % 2 != 0)
            {
                count++;
            }
            if (c % 2 != 0)
            {
                count++;
            }
            if (d % 2 != 0)
            {
                count++;
            }

            if (count >= 2)
            {
                return 1;
            }
            return 2;
        }
        /// <summary>
        /// eranish tvi miavor=har+tas return tru, else false
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool sumTwoOne(int a)
        {
            int har = a / 100;
            int tas = (a - (har * 100)) / 10;
            int miav = (a - (har * 100) - tas * 10);
            if (miav == har + tas)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// eranish tvi miavorneri mej kan havasar tver return tru, else false
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool eranishTviMiavorHavasar(int a)
        {
            int har = a / 100;
            int tas = (a - (har * 100)) / 10;
            int miav = (a - (har * 100) - tas * 10);
            if (miav == tas || tas == har || miav == har)
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// eranish tvi ev ir tvanshanneri haraberutyun, ete eranish tiv>k, else hakarak
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double eranishTviHarabVal(int a)
        {
            Random r = new Random();
            double number;
            int k = r.Next(100, 999);
            int har = a / 100;
            int tas = (a - (har * 100)) / 10;
            int miav = (a - (har * 100) - tas * 10);

            if (a > k)
            {
                number = (double)a / (har + tas + miav);
            }
            else
            {
                number = (double)(har + tas + miav) / a;
            }
            return number;
        }
        /// <summary>
        /// eranish tveri miavorneric gtnel mecaguyn
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int eranishMecTiv(int a)
        {
            int har = a / 100;
            int tas = (a - (har * 100)) / 10;
            int miav = (a - (har * 100) - tas * 10);

            if (har > tas && har > miav)
            {
                return har;
            }
            if (tas > har && tas > miav)
            {
                return tas;
            }
            return miav;
        }
        /// <summary>
        /// eranish tveri miavorneric gtnel poqr
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int eranishTivPoqr(int a)
        {
            int har = a / 100;
            int tas = (a - (har * 100)) / 10;
            int miav = (a - (har * 100) - tas * 10);

            if (har <= tas && har <= miav)
            {
                return har;
            }
            if (tas <= har && tas <= miav)
            {
                return tas;
            }
            return miav;
        }
        /// <summary>
        ///  eranish Tvi Miavor Mec Tasnavor
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double eranishTviMiavorMecTas(int a)
        {
            double number;
            int har = a / 100;
            int tas = (a - (har * 100)) / 10;
            int miav = (a - (har * 100) - tas * 10);

            if (miav > tas)
            {
                number = (double)(har + tas + miav) / a;
                return number;
            }

            return (double)a;
        }
        /// <summary>
        /// eranish Tiv>300,return tas/miavor,else har/miav 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double eranishMecEreqharyur(int a)
        {
            int har = a / 100;
            int tas = (a - (har * 100)) / 10;
            int miav = (a - (har * 100) - tas * 10);
            double number;

            if (a > 300)
            {
                number = (double)tas / miav;
            }
            else
            {
                number = (double)har /miav;
            }
            return number;
        }
        /// <summary>
        /// ete eranish tvi tasnavori ev haryuravori gumar ec e 5, veradardznel 'a', hakarak depqum 'b'
        /// </summary>
        /// <param name="a"></param>
        public static void simbolF(int a)
        {
            string f;
            int har = a / 100;
            int tas = (a - (har * 100)) / 10;
            int miav = (a - (har * 100) - tas * 10);
            if(tas+har < 5)
            {
                f = "a";
            }
            else
            {
                f= "b";
            }
            Console.Write("ete eranish tvi tasnavori ev haryuravori gumar ec e 5, veradardznel 'a', hakarak depqum 'b':");
            Console.WriteLine(f);
        }
        /// <summary>
        /// eranish tvi miavorner dasavorel Achman Kargi
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int[] eranishAchmanKargi(int a)
        {
            int har = a / 100;
            int tas = (a - (har * 100)) / 10;
            int miav = (a - (har * 100) - tas * 10);
            int[] array = {har,tas,miav};
            int t;
            for(int i = 0; i < array.Length-1; i++)
            {
                for(int j=1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// eranish tvi miavorner dasavorel Nvazman Kargi
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int[] eranishNvazmanKargi(int a)
        {
            int har = a / 100;
            int tas = (a - (har * 100)) / 10;
            int miav = (a - (har * 100) - tas * 10);
            int[] array = { har, tas, miav };
            int t;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// qaranish Tiv miav+tas = haz+har
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool miavorTasHavHarHaz(int a)
        {
            int haz = a / 1000;
            int har = (a % 1000)/100;
            int tas = ((a % 1000) - har *100)/ 10;
            int miav = (a % 1000) - har * 100 - 10*tas;
            if(tas+miav == har + haz)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double qaranishTviHaraberutyun(int a)
        {
            double d;
            int haz = a / 1000;
            int har = (a % 1000) / 100;
            int tas = ((a % 1000) - har * 100) / 10;
            int miav = (a % 1000) - har * 100 - 10 * tas;
            if (a<5000)
            {
                d = (double) a/(miav+har);
            }
            else
            {
                d = (double)a / (haz+tas);
            }
            return d;
        }
        /// <summary>
        /// qaranish Tiv parunakum e 1
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int getOneInQaranish(int a)
        {
            int haz = a / 1000;
            int har = (a % 1000) / 100;
            int tas = ((a % 1000) - har * 100) / 10;
            int miav = (a % 1000) - har * 100 - 10 * tas;
            int[] arrayInt = new int[4];
            arrayInt[0] = haz;
            arrayInt[1] = har;
            arrayInt[2] = tas;
            arrayInt[3] = miav;

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if ( arrayInt[i] ==1)
                {
                    return 1;
                }
            }

            return 0;
        }
        /// <summary>
        /// qaranish Tiv miav+tas<5, y="s", else y="d"
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string qaranishMGum(int a)
        {
            int haz = a / 1000;
            int har = (a % 1000) / 100;
            int tas = ((a % 1000) - har * 100) / 10;
            int miav = (a % 1000) - har * 100 - 10 * tas;

            string y = "";
            if ((miav + tas)<5)
            {
                y = "s";
            }
            else
            {
                y = "d";
            }

            return y;
        }
        /// <summary>
        /// aranish Tiv miav*tas=12, y=1, else y=0
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string qaranishMTArtadryal(int a)
        {
            int haz = a / 1000;
            int har = (a % 1000) / 100;
            int tas = ((a % 1000) - har * 100) / 10;
            int miav = (a % 1000) - har * 100 - 10 * tas;

            string y = "";
            if ((miav * tas) == 12)
            {
                y = "y=12";
            }
            else
            {
                y = "y=0";
            }

            return y;
        }
        /// <summary>
        /// qaranish Tiv arajin kam verjin nish 4
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string qaranishFirstLastGetFor(int a)
        {
            int haz = a / 1000;
            int har = (a % 1000) / 100;
            int tas = ((a % 1000) - har * 100) / 10;
            int miav = (a % 1000) - har * 100 - 10 * tas;

            string y = "";
            if (haz == 4 || miav == 4)
            {
                y = "yes";
            }
            else
            {
                y = "no";
            }

            return y;
        }
        /// <summary>
        /// qaranish tvi miavorner gumari qarakusin havasar e qaranish tvin
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string qarIrTGumQarakusi(int a)
        {
            int haz = a / 1000;
            int har = (a % 1000) / 100;
            int tas = ((a % 1000) - har * 100) / 10;
            int miav = (a % 1000) - har * 100 - 10 * tas;
            int t = haz + har + tas + miav;
            string y = "";
            if (t*t == a)
            {
                y = "yes";
            }
            else
            {
                y = "no";
            }

            return y;
        }
    }

}

