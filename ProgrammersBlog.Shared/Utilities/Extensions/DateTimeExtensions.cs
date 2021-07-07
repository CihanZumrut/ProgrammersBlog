using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Extensions
{
    public static class DateTimeExtensions
    {
        public static string FullDateAndTimeStringWithUnderscore(this DateTime datetime)
        {
            return $"{datetime.Millisecond}_{datetime.Second}_{datetime.Minute}_{datetime.Hour}_{datetime.Day}_{datetime.Month}_{datetime.Year}";

            /*
             *CihanZumrut_587_5_38_12_3_10_2021_CihanZumrutResmi.png
             *AliVeli_601_5_38_12_3_10_2021.png
             */
        }
    }
}
