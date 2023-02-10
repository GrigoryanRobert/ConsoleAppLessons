namespace ConsoleAppLessons1
{
    class TestClass
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            if (a > b)
            {
                Console.WriteLine("A big than B");
            }
            else
            {
                Console.WriteLine("B big than A");
            }

            Console.WriteLine(a > b ? "A big than B" : "B big than A");
        }
    }

}
