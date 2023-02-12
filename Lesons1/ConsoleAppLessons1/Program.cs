namespace ConsoleAppLessons1

{
    class TestClass
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
        }

        /// <summary>
        /// //21.kartacen a,b,c tveric meci arjeq@
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int bigNumber(int a, int b, int c)
        {
            int[] arrayInt = new int[3];
            arrayInt[0] = a;
            arrayInt[1] = b;
            arrayInt[2] = c;

            int maxInt = arrayInt[0];

            for(int i=0;i<arrayInt.Length; i++)
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
           if(a*a == (b*b + c*c) )
            {
                return "y=1";
            }
            if(b*b == (a*a + c*c) )
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
        /// kartacen true, ete trvac tver erkrachapakan progresia en
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool numberGeometricProgres(int a, int b, int c)
        {
            float q = (float) b / (float)a;
            if((float)c == (float)(a * q*q))
            {
                return true;
            }
            return false;
        }

    }

}
