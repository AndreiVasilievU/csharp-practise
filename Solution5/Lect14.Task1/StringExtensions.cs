using System;
using System.Collections.Generic;
using System.Text;

namespace Lect14.Task1
{
    static  class StringExtensions
    {
        public static void NewString(this String str)
        {
            str.Substring(4);
            str.Insert(4, "...");
        }
    }
}
