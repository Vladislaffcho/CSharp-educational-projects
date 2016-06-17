namespace WF2
{
    public static class Helper
    {
        public static int GetInt(this string source)
        {
            ///
            /// 
            /// 
            /// 
            /// 
            /// 
            ///


            int i = 0;
            if (int.TryParse(source, out i))
            {
                return 1;
            }
            return 0;
        }
    }
}