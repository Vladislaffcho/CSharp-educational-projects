namespace WindowsForm
{
    public static class Helper
    {
        /// <summary>
        /// Parse string to int or double
        /// </summary>
        /// <param name="source"></param>
        /// <returns>
        /// If unable parse to int or double returns 0
        /// </returns>
        public static int GetInt(this string source)
        {
            int i;
            if (int.TryParse(source, out i))
            {
                return i;
            }
            return -1;
        }

        public static double GetDouble(this string source)
        {
            double i;
            if (double.TryParse(source, out i))
            {
                return i;
            }
            return -1;
        }
    }
}