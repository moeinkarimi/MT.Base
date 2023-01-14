namespace MT.Base
{
    public static class NumberExtention
    {
        #region To Persian Number
        public static string toPersianNumber(this string input)
        {
            string[] persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            for (int j = 0; j < persian.Length; j++)
                input = input.Replace(j.ToString(), persian[j]);

            return input;
        }

        public static string toPersianNumber(this int input)
        {
            string converted = input.ToString();
            string[] persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            for (int j = 0; j < persian.Length; j++)
                converted = converted.Replace(j.ToString(), persian[j]);

            return converted;
        }

        public static string toPersianNumber(this long input)
        {
            string converted = input.ToString();
            string[] persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            for (int j = 0; j < persian.Length; j++)
                converted = converted.Replace(j.ToString(), persian[j]);

            return converted;
        }

        public static string toPersianNumber(this decimal input)
        {
            string converted = input.ToString();
            string[] persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            for (int j = 0; j < persian.Length; j++)
                converted = converted.Replace(j.ToString(), persian[j]);

            return converted;
        }

        public static string toPersianNumber(this short input)
        {
            string converted = input.ToString();
            string[] persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            for (int j = 0; j < persian.Length; j++)
                converted = converted.Replace(j.ToString(), persian[j]);

            return converted;
        }

        public static string toPersianNumber(this float input)
        {
            string converted = input.ToString();
            string[] persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            for (int j = 0; j < persian.Length; j++)
                converted = converted.Replace(j.ToString(), persian[j]);

            return converted;
        }

        public static string toPersianNumber(this double input)
        {
            string converted = input.ToString();
            string[] persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            for (int j = 0; j < persian.Length; j++)
                converted = converted.Replace(j.ToString(), persian[j]);

            return converted;
        }
        #endregion

        #region Format Number
        public static string FormatNumber(this int num, bool isPersian = false)
        {
            if (num >= 1000000000)
                return (num / 1000000000D).ToString("0.#") + (isPersian ? " میلیارد" : " B");

            if (num >= 1000000)
                return (num / 1000000D).ToString("0.#") + (isPersian ? " میلیون" : " M");

            if (num >= 1000)
                return (num / 1000D).ToString("0.#") + (isPersian ? " هزار" : " K");

            return num.ToString("#");
        }

        public static string FormatNumber(this long num, bool isPersian = false)
        {
            if (num >= 1000000000)
                return (num / 1000000000D).ToString("0.#") + (isPersian ? " میلیارد" : " B");

            if (num >= 1000000)
                return (num / 1000000D).ToString("0.#") + (isPersian ? " میلیون" : " M");

            if (num >= 1000)
                return (num / 1000D).ToString("0.#") + (isPersian ? " هزار" : " K");

            return num.ToString("#");
        }

        public static string FormatNumber(this float num, bool isPersian = false)
        {
            if (num >= 1000000000)
                return (num / 1000000000D).ToString("0.#") + (isPersian ? " میلیارد" : " B");

            if (num >= 1000000)
                return (num / 1000000D).ToString("0.#") + (isPersian ? " میلیون" : " M");

            if (num >= 1000)
                return (num / 1000D).ToString("0.#") + (isPersian ? " هزار" : " K");

            return num.ToString("#");
        }

        public static string FormatNumber(this double num, bool isPersian = false)
        {
            if (num >= 1000000000)
                return (num / 1000000000D).ToString("0.#") + (isPersian ? " میلیارد" : " B");

            if (num >= 1000000)
                return (num / 1000000D).ToString("0.#") + (isPersian ? " میلیون" : " M");

            if (num >= 1000)
                return (num / 1000D).ToString("0.#") + (isPersian ? " هزار" : " K");

            return num.ToString("#");
        }
        #endregion

    }
}
