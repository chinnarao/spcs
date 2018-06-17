namespace extensions
{
    public static partial class StringExtensions
    {
        public static double StringToDouble(this string str)
        {
            double result;
            double.TryParse(str, out result);
            return result;
        }
    }
}
