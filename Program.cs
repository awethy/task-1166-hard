namespace program
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LastDigit(one: "2", two: "9"));
            Console.ReadKey();
        }

        static double LastDigit(string one, string two)
        {
            if (one == string.Empty || two == string.Empty) return 0d;
            if (two.Length == 1 && Convert.ToInt16(two[^1].ToString()) == 0) return 1;
            int slice = two.Length > 1 ? 2 : 1;
            return Math.Pow(Convert.ToInt32(one[^1].ToString()), Convert.ToInt16(two[^slice..]) % 4 == 0 ? 4 : Convert.ToInt16(two[^slice..]) % 4) % 10;
        }
    }
}