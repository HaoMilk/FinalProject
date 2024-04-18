using System;
using System.Collections.Generic;

namespace FinalProject.Common.Const
{
    public static class GioiTinhConsts
    {
        public const string Male = "M";
        public const string Female = "F";
        public const string Others = "O";

        public static List<string> GetGioiTinhList()
        {
            var gioiTinhList = new List<string> { Male, Female, Others };
            return gioiTinhList;
        }
    }
}
