using News.constant;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace News.Util
{
    public static class CommonUtil
    {
        public static string GetTypeFilm(int film_movie)
        {
            string type_film = ComConst.BLANK;
            //switch (film_movie)
            //{
            //    case 1:
            //        type_film = DivConst.GetName(FilmMovie.ANIME);
            //        break;
            //    case 2:
            //        type_film = DivConst.GetName(FilmMovie.MOVIE);
            //        break;
            //    case 3:
            //        type_film = DivConst.GetName(FilmMovie.TV_SERIES);
            //        break;
            //    default:
            //        break;
            //}
            return type_film;
        }


        public static string ReplaceDash(string con)
        {
            if (!string.IsNullOrEmpty(con))
            {
                con = con.Replace("-", " ");
            }
            return con;
        }

        public static string ToFirstUpper(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (str.Length > 1)
                {
                    str = str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1).ToLower();
                }
                else
                {
                    str = str.ToUpper();
                }
            }
            return str;
        }

        public static string ReplaceWildcardCharacters(string paramatter)
        {
            if (!string.IsNullOrEmpty(paramatter))
            {
                return paramatter.Replace("%", "/%").Replace("_", "/_");
            }
            return ComConst.BLANK;
        }

        public static string ConvetTime(int totalMinutes)
        {
            TimeSpan ts = TimeSpan.FromMinutes(totalMinutes);
            if (ts.Hours == 0)
            {
                return string.Format("{0}min", ts.Minutes);
            }
            return string.Format("{0}h {1}min", ts.Hours, ts.Minutes);
        }

        public static Dictionary<int, Dictionary<int, string>> GetCommingYear(int CommingYear)
        {
            Dictionary<int, Dictionary<int, string>> list = new Dictionary<int, Dictionary<int, string>>();
            DateTime dateTime = DateTime.Now;
            int currentYear = dateTime.Year;
            int currentMonth = dateTime.Month;
            for (int i = currentYear - 2; i <= CommingYear; i++)
            {
                list.Add(i, GetAllMonths());
            }
            return list;
        }

        public static Dictionary<int, string> GetAllMonths(int currentMonth = 1)
        {
            Dictionary<int, string> listMonth = new Dictionary<int, string>();
            for (int i = currentMonth; i <= 12; i++)
            {
                listMonth.Add(i, DateTimeFormatInfo.CurrentInfo.GetMonthName(i));
            }
            return listMonth;
        }

        public static string StripHTML(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                input = Regex.Replace(input, @"<[^>]+>|&nbsp;", String.Empty);
            }
            return input;
        }

        public static string UrlFriendly(string text, int maxLength = 0)
        {
            // Return empty value if text is null
            if (text == null) return "";
            var normalizedString = text
                // Make lowercase
                .ToLowerInvariant()
                // Normalize the text
                .Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();
            var stringLength = normalizedString.Length;
            var prevdash = false;
            var trueLength = 0;
            char c;
            for (int i = 0; i < stringLength; i++)
            {
                c = normalizedString[i];
                switch (CharUnicodeInfo.GetUnicodeCategory(c))
                {
                    // Check if the character is a letter or a digit if the character is a
                    // international character remap it to an ascii valid character
                    case UnicodeCategory.LowercaseLetter:
                    case UnicodeCategory.UppercaseLetter:
                    case UnicodeCategory.DecimalDigitNumber:
                        if (c < 128)
                            stringBuilder.Append(c);
                        else
                            stringBuilder.Append(RemapInternationalCharToAscii(c));
                        prevdash = false;
                        trueLength = stringBuilder.Length;
                        break;
                    // Check if the character is to be replaced by a hyphen but only if the last character wasn't
                    case UnicodeCategory.SpaceSeparator:
                    case UnicodeCategory.ConnectorPunctuation:
                    case UnicodeCategory.DashPunctuation:
                    case UnicodeCategory.OtherPunctuation:
                    case UnicodeCategory.MathSymbol:
                        if (!prevdash)
                        {
                            stringBuilder.Append('-');
                            prevdash = true;
                            trueLength = stringBuilder.Length;
                        }
                        break;
                }
                // If we are at max length, stop parsing
                if (maxLength > 0 && trueLength >= maxLength)
                    break;
            }
            // Trim excess hyphens
            var result = stringBuilder.ToString().Trim('-');
            // Remove any excess character to meet maxlength criteria
            return maxLength <= 0 || result.Length <= maxLength ? result : result.Substring(0, maxLength);
        }

        public static string RemapInternationalCharToAscii(char c)
        {
            string s = c.ToString().ToLowerInvariant();
            if ("àåáâäãåą".Contains(s))
            {
                return "a";
            }
            else if ("èéêëę".Contains(s))
            {
                return "e";
            }
            else if ("ìíîïı".Contains(s))
            {
                return "i";
            }
            else if ("òóôõöøőð".Contains(s))
            {
                return "o";
            }
            else if ("ùúûüŭů".Contains(s))
            {
                return "u";
            }
            else if ("çćčĉ".Contains(s))
            {
                return "c";
            }
            else if ("żźž".Contains(s))
            {
                return "z";
            }
            else if ("śşšŝ".Contains(s))
            {
                return "s";
            }
            else if ("ñń".Contains(s))
            {
                return "n";
            }
            else if ("ýÿ".Contains(s))
            {
                return "y";
            }
            else if ("ğĝ".Contains(s))
            {
                return "g";
            }
            else if (c == 'ř')
            {
                return "r";
            }
            else if (c == 'ł')
            {
                return "l";
            }
            else if (c == 'đ')
            {
                return "d";
            }
            else if (c == 'ß')
            {
                return "ss";
            }
            else if (c == 'þ')
            {
                return "th";
            }
            else if (c == 'ĥ')
            {
                return "h";
            }
            else if (c == 'ĵ')
            {
                return "j";
            }
            else
            {
                return "";
            }
        }
    }
}