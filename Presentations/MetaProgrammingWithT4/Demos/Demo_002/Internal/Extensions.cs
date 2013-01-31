// ----------------------------------------------------------------------------------------------
// Copyright (c) WCOM AB.
// ----------------------------------------------------------------------------------------------
// This source code is subject to terms and conditions of the Microsoft Public License. A 
// copy of the license can be found in the License.html file at the root of this distribution. 
// If you cannot locate the  Microsoft Public License, please send an email to 
// dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
//  by the terms of the Microsoft Public License.
// ----------------------------------------------------------------------------------------------
// You must not remove this notice, or any other, from this software.
// ----------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Demo_002.Internal
{
    static class Extensions
    {
        public static Regex CreateRegex(this string regex)
        {
            return new Regex(
                regex ?? "",
                RegexOptions.Compiled | RegexOptions.CultureInvariant);
        }

        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static int Parse(this string s, int i)
        {
            if (s.IsNullOrEmpty()) return i;
            int v;
            return
                int.TryParse(
                    s,
                    NumberStyles.Integer,
                    CultureInfo.InvariantCulture,
                    out v
                    )
                    ? v
                    : i
                ;
        }

        public static int Clamp(this int v, int l, int u)
        {
            if (v < l)
            {
                return l;
            }

            if (v > u)
            {
                return u;
            }

            return v;
        }

        public static int Abs(this int l)
        {
            return Math.Abs(l);
        }

        public static string Join(IEnumerable<string> values, string delimiter = null)
        {
            values = values ?? new string[0];
            delimiter = delimiter ?? ", ";
            return string.Join(delimiter, values);
        }

        public static TValue OnTrue<TValue>(this bool b, TValue trueValue, TValue falseValue = default(TValue))
        {
            return b ? trueValue : falseValue;
        }

        public static TValue OnFalse<TValue>(this bool b, TValue falseValue, TValue trueValue = default(TValue))
        {
            return b ? trueValue : falseValue;
        }
    }
}