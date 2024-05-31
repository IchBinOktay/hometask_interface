﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalize
{
    internal static class StringExt
    {
        public static string GetCapitalize(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);

        }
    }
}
