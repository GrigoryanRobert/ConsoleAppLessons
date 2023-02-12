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

            //21.kartacen a,b,c tveric meci arjeq@

            int maxInt = bigNumber(4, 15, 15);
            Console.WriteLine(maxInt);
            //22.kartacen a,b,c tveric poqri arjeq@
            int minInt = minNumber(100, 7, 15);
            Console.WriteLine(minInt);
            //23.kartacen true ,ete a,b,c tveric mek havasar  mekin
            bool oneEqualNum = oneEqual(18, 7, 15);
            Console.WriteLine(oneEqualNum);
               //23.kartacen true ,ete a,b,c tveric 2 havasar e 2
            bool twoEqualTwoNum = twoEqualTwo(2, 7, 2);
            Console.WriteLine(twoEqualTwoNum);


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
            switch (a, b, c)
            {
                case a == b && a == 2: return true;
                case a == c && a == 2: return true;
                case b == c && b == 2: return true;
                default: return false;
            }
            //if(a == b && a == 2)
            //{
            //    return true;
            //}
            //if (a == c && a == 2)
            //{
            //    return true;
            //}
            //if (b == c && b == 2)
            //{
            //    return true;
            //}
            //return false;
        }

        public static string threeAngel(int a, int b, int c)
        {
           if(a*a == (b*b + c*c) )
            {
                return "y+1";
            }
        }


    }

}
