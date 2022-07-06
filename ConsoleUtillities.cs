using Figgle;

namespace utils
{
    public static class print
    {
        public static void str(string str)
        {
            Console.WriteLine(str);
        }

        public static void ascii(string str)
        {
            Console.WriteLine(FiggleFonts.Standard.Render(str));
        }

        public static void nl()
        {
            Console.WriteLine();
        }
    }

    public static class input
    {
        public static string key()
        {
            return Console.ReadKey().KeyChar.ToString();
        }

        public static string line()
        {
            return Console.ReadLine()!;
        }

        public static void contKey(bool cls = false)
        {
            if (!cls)
            {
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    public static class general
    {
        public static void clear()
        {
            Console.Clear();
        }
    }
}