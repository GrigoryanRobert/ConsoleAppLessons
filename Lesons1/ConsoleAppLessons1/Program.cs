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
            //calculator
             string value;
            do
            {
                int res;
                Console.Write("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();
 
                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Addition:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtraction:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division:" + res);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value=="y" || value=="Y");

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

            //68 qaranish tvi miav>tas, return miav*tas, else 1 
            int qarArtNum = qarArt(4835);
            Console.Write("qaranish tvi miav>tas, return miav*tas, else 1:");
            Console.WriteLine(qarArtNum);
            //69 qaranish tvi miavorneri sum>20,y=1,else y=0 
            byte qarTivSumNum = qarTivSum(8835);
            Console.Write("qaranish tvi miavorneri sum>20,y=1,else y=0 :");
            Console.WriteLine(qarTivSumNum);
            //70qaranish tvi miavorneri artadryal>200,return 0,else 1 
            byte qarTivArtNum = qarTivArt(8835);
            Console.Write("qaranish tvi miavorneri artadryal>200,return 0,else 1:");
            Console.WriteLine(qarTivArtNum);
            //151 bnnakan tveri sum,voronc vra aranc mnacordi bajanvum e trvac n bnakan tiv  
            int bnakanTveriSumNum = bnakanTveriSum(9);
            Console.Write("bnnakan tveri sum,voronc vra aranc mnacordi bajanvum e trvac n bnakan tiv  :");
            Console.WriteLine(bnakanTveriSumNum);
            //152 bnnakan tveri artadryal,voronc vra aranc mnacordi bajanvum e trvac n bnakan tiv  
            int bnakanTveriArtNum = bnakanTveriArt(9);
            Console.Write("bnnakan tveri artadryal,voronc vra aranc mnacordi bajanvum e trvac n bnakan tiv  :");
            Console.WriteLine(bnakanTveriArtNum);
            //153 bnnakan tveri sum,voronc vra  n bnakan tiv  bajanelis mnacordum kmna 2  
            int bnakanTveriBajanumSumNum = bnakanTveriBajanumSum(9);
            Console.Write("bnnakan tveri sum,voronc vra  n bnakan tiv  bajanelis mnacordum kmna 2:");
            Console.WriteLine(bnakanTveriBajanumSumNum);
            //154 bnnakan tveri sum,voronc vra n bnakan tiv bajanelis mnacordum kmna 3
            int bnakanTveriArtEreqNum = bnakanTveriArtEreq(9);
            Console.Write("bnnakan tveri sum,voronc vra n bnakan tiv bajanelis mnacordum kmna 3:");
            Console.WriteLine(bnakanTveriArtEreqNum);
            //155 bolor erknish tveri sum, voronq bazmapatik en 3
            int erknishBazmapatikNum = erknishBazmapatik();
            Console.Write("bolor erknish tveri sum, voronq bazmapatik en 3:");
            Console.WriteLine(erknishBazmapatikNum);
            //156  bolor erknish tveri artadryal, voronq bazmapatik en 3 && 5
            ulong erknishBazmapatikArtadrNum = erknishBazmapatikArtadr();
            Console.Write(" bolor erknish tveri artadryal, voronq bazmapatik en 3 && 5:");
            Console.WriteLine(erknishBazmapatikArtadrNum);
            //157 bolor eranish tveri sum, voronq bazmapatik chen 5
            int eranishBazmapatikChenHingNum = eranishBazmapatikChenHing();
            Console.Write(" bolor eranish tveri sum, voronq bazmapatik chen 5:");
            Console.WriteLine(eranishBazmapatikChenHingNum);
            //158 bolor eranish tveri art, voronq bazmapatik chen 2 && 3
            ulong eranishBazmapatikChenErkuEreqArtNum = eranishBazmapatikChenErkuEreqArt();
            Console.Write(" bolor eranish tveri art, voronq bazmapatik chen 2 && 3:");
            Console.WriteLine(eranishBazmapatikChenErkuEreqArtNum);
            //159 bolor eranish tveri art, voronq bajanac 3 kmna 1 mnacord, is bajanac 4-i 2
            ulong eranishBazmapatikChenMekChorsArtNum = eranishBazmapatikChenMekChorsArt();
            Console.Write("bolor eranish tveri art, voronq bajanac 3 kmna 1 mnacord, is bajanac 4-i 2:");
            Console.WriteLine(eranishBazmapatikChenMekChorsArtNum);
            //160 eranish amenapoqr tiv vor bazmapatkac 16 kstacvi bnakan tvi qarakusi
            int smollEranishBnTivQarNum = smollEranishBnTivQar();
            Console.Write("eranish amenapoqr tiv vor bazmapatkac 16 kstacvi bnakan tvi qarakusi:");
            Console.WriteLine(smollEranishBnTivQarNum);
            
            //161 qaranish amenapoqr tiv vor bazmapatkac 26 kstacvi bnakan tvi qarakusi
            int smolQaranisBnTivQarNum = smolQaranisBnTivQar();
            Console.Write("qaranish amenapoqr tiv vor bazmapatkac 26 kstacvi bnakan tvi qarakusi:");
            Console.WriteLine(smolQaranisBnTivQarNum);
             
            //162 qaranish amenamec tiv vor bazmapatkac 14 kstacvi bnakan tvi qarakusi
            int bigQaranisBnTivQarNum = bigQaranisBnTivQar(14);
            Console.Write("qaranish amenamec tiv vor bazmapatkac 14 kstacvi bnakan tvi qarakusi:");
            Console.WriteLine(bigQaranisBnTivQarNum);

            //163 qaranish amenamec tiv vor bazmapatkac 18 kstacvi bnakan tvi qarakusi
            int bigQaranisBnTivQarNum2 = bigQaranisBnTivQar(18);
            Console.Write("qaranish amenamec tiv vor bazmapatkac 18 kstacvi bnakan tvi qarakusi:");
            Console.WriteLine(bigQaranisBnTivQarNum2);
            
            //164 amenapoqr eranish tiv vori qarakusi armat> n bnakan tvic
            int eranishSmalQarArmatNum = eranishSmalQarArmat(20);
            Console.Write("amenapoqr eranish tiv vori qarakusi armat> n bnakan tvic:");
            Console.WriteLine(eranishSmalQarArmatNum);
            
            //165 trvac tiv handisanum e 3 astichan, te voch
            bool bnakanTivEreqiAstichanNum = bnakanTivEreqiAstichan(27);
            Console.Write("trvac tiv handisanum e 3 astichan, te voch:");
            Console.WriteLine(bnakanTivEreqiAstichanNum);
            //166 trvac tiv handisanum e 4 astichan, te voch
            byte bnakanTivChorsiAstichanNum = bnakanTivChorsiAstichan(64);
            Console.Write("trvac tiv handisanum e 4 astichan, te voch:");
            Console.WriteLine(bnakanTivChorsiAstichanNum);

            //------zangvac----------

            //211.drakan tarreri mijin tvabanakan
            int[] arrayInt = { 10, 5, 7,10, 2, 9,18 };
            double drakanTarMijinTvabanakanNum = drakanTarMijinTvabanakan(arrayInt);
            Console.Write("drakan tarreri mijin tvabanakan:");
            Console.WriteLine(drakanTarMijinTvabanakanNum); 
            //212.drakan tarreri mijin qarakusayin
            double drakanTarMijinQarakusayinNum = drakanTarMijinQarakusayin(arrayInt);
            Console.Write("drakan tarreri mijin qarakusayin:");
            Console.WriteLine(drakanTarMijinQarakusayinNum);

            //213.bacasakan tarreri mijin qarakusayin
            double bacasakanTarMijinQarakusayinNum = bacasakanTarMijinQarakusayin(arrayInt);
            Console.Write("bacasakan tarreri mijin qarakusayin:");
            Console.WriteLine(bacasakanTarMijinQarakusayinNum);
            //214.bacasakan tarreri mijin tvabanakan
            double bacasakanTarMijinTvabanakanNum = bacasakanTarMijinTvabanakan(arrayInt);
            Console.Write("bacasakan tarreri mijin tvabanakan:");
            Console.WriteLine(bacasakanTarMijinTvabanakanNum);
            //215.zuyg index unecox tarreri gumar
            int zuygIndexTarSumNum = zuygIndexTarSum(arrayInt);
            Console.Write("zuyg index unecox tarreri gumar:");
            Console.WriteLine(zuygIndexTarSumNum);
            //216.zuyg index unecox tarreri artadryal
            int zuygIndexTarArtNum = zuygIndexTarArt(arrayInt);
            Console.Write("zuyg index unecox tarreri artadryal:");
            Console.WriteLine(zuygIndexTarArtNum);
            //217.kent index unecox tarreri qarakusineri artadryal
            int kentIndexTarQarArtNum = kentIndexTarQarArt(arrayInt);
            Console.Write("kent index unecox tarreri qarakusineri artadryal:");
            Console.WriteLine(kentIndexTarQarArtNum);
            


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

            int firstInt = arrayInt[0];

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
                number = (double)har / miav;
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
            if (tas + har < 5)
            {
                f = "a";
            }
            else
            {
                f = "b";
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
            int[] array = { har, tas, miav };
            int t;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
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
            int har = (a % 1000) / 100;
            int tas = ((a % 1000) - har * 100) / 10;
            int miav = (a % 1000) - har * 100 - 10 * tas;
            if (tas + miav == har + haz)
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
            if (a < 5000)
            {
                d = (double)a / (miav + har);
            }
            else
            {
                d = (double)a / (haz + tas);
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
                if (arrayInt[i] == 1)
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
            if ((miav + tas) < 5)
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
            if (t * t == a)
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
        /// qaranish tvi miav>tas, return miav*tas, else 1
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int qarArt(int a)
        {
            int haz = a / 1000;
            int har = (a % 1000) / 100;
            int tas = ((a % 1000) - har * 100) / 10;
            int miav = (a % 1000) - har * 100 - 10 * tas;
            int t = haz + har + tas + miav;
            int y ;
            if (miav > tas)
            {
                y = miav*har;
            }
            else
            {
                y = 1;
            }

            return y;
        }
        /// <summary>
        /// qaranish tvi miavorneri sum>20,y=1,else y=0
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static byte qarTivSum(int a)
        {
            int haz = a / 1000;
            int har = (a % 1000) / 100;
            int tas = ((a % 1000) - har * 100) / 10;
            int miav = (a % 1000) - har * 100 - 10 * tas;
            int t = haz + har + tas + miav;
            byte y;
            if (t > 20)
            {
                y = 1;
            }
            else
            {
                y = 0;
            }

            return y;
        }
        /// <summary>
        /// qaranish tvi miavorneri artadryal>200,return 0,else 1
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static byte qarTivArt(int a)
        {
            int haz = a / 1000;
            int har = (a % 1000) / 100;
            int tas = ((a % 1000) - har * 100) / 10;
            int miav = (a % 1000) - har * 100 - 10 * tas;
            int t = haz * har * tas * miav;
            byte y;
            if (t > 200)
            {
                y = 0;
            }
            else
            {
                y = 1;
            }

            return y;
        }

        /// <summary>
        /// bnnakan tveri sum,voronc vra aranc mnacordi bajanvum e trvac n bnakan tiv  
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int bnakanTveriSum(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                if(n%i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        /// <summary>
        /// bnnakan tveri sum,voronc vra aranc mnacordi bajanvum e trvac n bnakan tiv  
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int bnakanTveriArt(int n)
        {
            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum *= i;
                }
            }
            return sum;
        }


        /// <summary>
        /// bnnakan tveri sum,voronc vra  n bnakan tiv  bajanelis mnacordum kmna 2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int bnakanTveriBajanumSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 2)
                {
                    sum += i;
                }
            }
            return sum;
        }

        /// <summary>
        /// bnnakan tveri sum,voronc vra n bnakan tiv bajanelis mnacordum kmna 3
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int bnakanTveriArtEreq(int n)
        {
            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 3)
                {
                    sum *= i;
                }
            }
            return sum;
        }
        /// <summary>
        /// bolor erknish tveri sum, voronq bazmapatik en 3
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int erknishBazmapatik()
        {
            int sum = 0;
            for(int i = 10; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        /// <summary>
        /// bolor erknish tveri artadryal, voronq bazmapatik en 3 && 5
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static ulong erknishBazmapatikArtadr()
        {
            ulong sum = 1;
            for (uint i = 10; i < 100; i++)
            {
                if (i % 3 == 0 && i%5 == 0)
                {
                    sum *= i;
                }
            }
            return sum;
        }

        /// <summary>
        /// bolor eranish tveri sum, voronq bazmapatik chen 5
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int eranishBazmapatikChenHing()
        {
            int sum = 0;
            for (int i = 100; i < 1000; i++)
            {
                if (i % 5 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        /// <summary>
        /// bolor eranish tveri art, voronq bazmapatik chen 2 && 3
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static ulong eranishBazmapatikChenErkuEreqArt()
        {
            ulong sum = 1;
            for (uint i = 100; i < 1000; i++)
            {
                if (i % 2 != 0 && i % 3 != 0)
                {
                    sum *= i;
                }
            }
            return sum;
        }

        /// <summary>
        /// bolor eranish tveri art, voronq /3 kmna 1 mnacord, is /4 2
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static ulong eranishBazmapatikChenMekChorsArt()
        {
            ulong sum = 1;
            for (uint i = 100; i < 1000; i++)
            {
                if (i % 3 == 1 && i % 4 == 2)
                {
                    sum *= i;
                }
            }
            return sum;
        }
        /// <summary>
        /// eranish amenapoqr tiv vor bazmapatkac 16 kstacvi bnakan tvi qarakusi
        /// </summary>
        /// <returns></returns>
        public static int smollEranishBnTivQar()
        {
            int x=0;
            for(int i = 100; i < 1000; i++)
            {
                double t = (double)Math.Sqrt(i * 16);
                if (t%1 == 0)
                {
                    x = i;break;
                }
            }
            return x;
        }
        /// <summary>
        /// qaranish amenapoqr tiv vor bazmapatkac 26 kstacvi bnakan tvi qarakusi
        /// </summary>
        /// <returns></returns>
        public static int smolQaranisBnTivQar()
        {
            int x = 0;
            for (int i = 1000; i < 10000; i++)
            {
                double t = (double)Math.Sqrt(i * 26);
                if (t % 1 == 0)
                {
                    x = i; break;
                }
            }
            return x;
        }
        /// <summary>
        /// qaranish amenamec tiv vor bazmapatkac 14 kstacvi bnakan tvi qarakusi
        /// </summary>
        /// <returns></returns>

        public static int bigQaranisBnTivQar(int n)
        {
            int x = 0;
            for (int i = 9999; i >= 1000; i--)
            {
                double t = (double)Math.Sqrt(i * n);
                if (t % 1 == 0)
                {
                    x = i; break;
                }
            }
            return x;
        }
        /// <summary>
        /// amenapoqr eranish tiv vori qarakusi armat> n bnakan tvic
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int eranishSmalQarArmat(int n)
        {
            int x = 0;

            for (int i=100; i < 1000; i++)
            {
                double t = (double)Math.Sqrt(i);
                if (t % 1 == 0)
                {
                    if (t > n)
                    {
                        x = i; break;
                    }
                  
                }
            }
            return (int)x;
        }
        /// <summary>
        /// trvac tiv handisanum e 3 astichan, te voch
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool bnakanTivEreqiAstichan(int a)
        {
            int t = 3;
            bool b= false;
            for(int i = 1; i < a / 2; i++)
            {
                t *= 3;
                if(t == a)
                {
                    b = true;break;
                }
            }
            return b;
        }

        /// <summary>
        /// trvac tiv handisanum e 4 astichan, te voch
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static byte bnakanTivChorsiAstichan(int a)
        {
            int t = 4;
            byte y = 0;
            for (int i = 1; i < a / 2; i++)
            {
                t *= 4;
                if (t == a)
                {
                    y = 1; break;
                }
            }
            return y;
        }

        //---------zangvac------------
        /// <summary>
        /// drakan tarreri mijin tvabanakan
        /// </summary>
        /// <param name="arrayInt"></param>
        /// <returns></returns>
        public static double drakanTarMijinTvabanakan(int[] arrayInt)
        {
            double sum = 0;
            double count = 0;
            for(int i= 0; i < arrayInt.Length; i++)
            {
                if(arrayInt[i] > 0)
                {
                    sum += (double)arrayInt[i];
                    count++;
                }
            }
            return (double)sum/count;
        }

        /// <summary>
        /// drakan tarreri mijin qarakusayin
        /// </summary>
        /// <param name="arrayInt"></param>
        /// <returns></returns>
        public static double drakanTarMijinQarakusayin(int[] arrayInt)
        {
            double sum = 0;
            double count = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] > 0)
                {
                    sum += (double)(arrayInt[i]* arrayInt[i]);
                    count++;
                }
            }
            return (double)Math.Sqrt(sum / count);
        }

        /// <summary>
        /// bacasakan tarreri mijin qarakusayin
        /// </summary>
        /// <param name="arrayInt"></param>
        /// <returns></returns>
        public static double bacasakanTarMijinQarakusayin(int[] arrayInt)
        {
            double sum = 0;
            double count = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] < 0)
                {
                    sum += (double)(arrayInt[i] * arrayInt[i]);
                    count++;
                }
            }
            return -(double)Math.Sqrt(sum / count);
        }

        /// <summary>
        /// bacasakan tarreri mijin tvabanakan
        /// </summary>
        /// <param name="arrayInt"></param>
        /// <returns></returns>
        public static double bacasakanTarMijinTvabanakan(int[] arrayInt)
        {
            double sum = 0;
            double count = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] < 0)
                {
                    sum += (double)arrayInt[i];
                    count++;
                }
            }
            return (double)sum / count;
        }
        /// <summary>
        /// zuyg index unecox tarreri gumar
        /// </summary>
        /// <param name="arrayInt"></param>
        /// <returns></returns>
        public static int zuygIndexTarSum(int[] arrayInt)
        {
            int sum = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (i%2 == 0 && i != 0)
                {
                    sum += arrayInt[i];
                }
            }
            return sum;
        }


        /// <summary>
        /// zuyg index unecox tarreri artadryal
        /// </summary>
        /// <param name="arrayInt"></param>
        /// <returns></returns>
        public static int zuygIndexTarArt(int[] arrayInt)
        {
            int sum = 1;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (i % 2 == 0 && i != 0)
                {
                    sum *= arrayInt[i];
                }
            }
            return sum;
        }

        public static int kentIndexTarQarArt(int[] arrayInt)
        {
            int sum = arrayInt[1]* arrayInt[1];
            for (int i = 3; i < arrayInt.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum *= arrayInt[i]* arrayInt[i];
                }
            }
            return sum;
        }


    }

}
