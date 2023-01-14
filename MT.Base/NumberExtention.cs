namespace MT.Base
{
    public static class NumberExtention
    {
        public static string toPersianNumber(this string input)
        {
            string[] persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            for (int j = 0; j < persian.Length; j++)
                input = input.Replace(j.ToString(), persian[j]);

            return input;
        }

        public static string FormatNumber(this int num)
        {

            if (num >= 1000000000)
                return (num / 1000000000D).ToString("0.#") + "B";

            if (num >= 1000000)
                return (num / 1000000D).ToString("0.#") + "M";

            if (num >= 1000)
                return (num / 1000D).ToString("0.#") + "K";

            return num.ToString("#");
        }

    }
}
