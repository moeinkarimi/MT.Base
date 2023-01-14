using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Base
{
    public static class DateTimeExtention
    {
        public static string ToPersianDateTime(this DateTime date, bool containsYear = true, bool containsMonth = true, bool containsDay = true, bool fullTime = false)
        {
            string persianDateTime = "";
            PersianCalendar pc = new PersianCalendar();
            if (fullTime)
            {
                persianDateTime = (containsYear ? pc.GetYear(date) + "/" : " ") + (containsMonth ? pc.GetMonth(date) + "/" : "") + (containsDay ? pc.GetDayOfMonth(date) + "" : "") + " " + date.ToString("HH:mm:ss");
            }
            else
            {
                persianDateTime = (containsYear ? pc.GetYear(date) + "/" : " ") + (containsMonth ? pc.GetMonth(date).ToString("00") + "/" : "") + (containsDay ? pc.GetDayOfMonth(date).ToString("00") + "" : "");
            }
            return persianDateTime;
        }
        public static string ToPersianDateTime(this DateTime? date, bool containsYear = true, bool containsMonth = true, bool containsDay = true, bool fullTime = false)
        {
            if (date != null)
            {
                string persianDateTime = "";
                PersianCalendar pc = new PersianCalendar();
                if (fullTime)
                {
                    persianDateTime = (containsYear ? pc.GetYear((DateTime)date) + "/" : " ") + (containsMonth ? pc.GetMonth((DateTime)date) + "/" : "") + (containsDay ? pc.GetDayOfMonth((DateTime)date) + "" : "") + " " + ((DateTime)date).ToString("HH:mm:ss");
                }
                else
                {
                    persianDateTime = (containsYear ? pc.GetYear((DateTime)date) + "/" : " ") + (containsMonth ? pc.GetMonth((DateTime)date) + "/" : "") + (containsDay ? pc.GetDayOfMonth((DateTime)date) + "" : "");
                }
                return persianDateTime;
            }
            else return "";
        }
        public static DateTime ToDateTime(this string persianDateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            var dateParts = GetDateParts(persianDateTime);
            DateTime dt = pc.ToDateTime(dateParts[0], dateParts[1], dateParts[2], 0, 0, 0, 0, 0);
            return dt;
        }

        public static int[] GetDateParts(string persianDate)
        {
            return persianDate.Split('/').Select(datePart => int.Parse(datePart)).ToArray();
        }

        public static DateTime ToDateTime(this DateTime persianDateTime, bool containsYear = true, bool containsMonth = true, bool containsDay = true)
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = new DateTime(persianDateTime.Year, persianDateTime.Month, persianDateTime.Day, pc);
            return dt;
        }

        public static string GetMonth(this int Month)
        {
            switch (Month)
            {
                case 0:
                    return "Jan";
                case 1:
                    return "Feb";
                case 2:
                    return "Mar";
                case 3:
                    return "Apr";
                case 4:
                    return "May";
                case 5:
                    return "Jun";
                case 6:
                    return "Jul";
                case 7:
                    return "Aug";
                case 8:
                    return "Sep";
                case 9:
                    return "Oct";
                case 10:
                    return "Nov";
                case 11:
                    return "Dec";
                default:
                    return "";
            }
        }

        public static string GetDay(this int Date)
        {
            return "";
        }
    }
}
