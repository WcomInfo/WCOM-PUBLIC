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
using Demo_007.Source.Extensions;

namespace Demo_007
{
    class Program
    {
        static readonly Dictionary<int, bool> s_primes = new Dictionary<int, bool>
                                                             {
                                                                 {1, false},
                                                                 {2, true},
                                                                 {3, true},
                                                                 {4, false},
                                                                 {5, true},
                                                                 {6, false},
                                                                 {7, true},
                                                                 {8, false},
                                                                 {9, false},
                                                             };

        static void Main(string[] args)
        {
            var value = 4;
            var isPrime = s_primes.Lookup(value);
            var line = "{0} is {1}prime".FormatWith(value, isPrime ? "" : "not ");
            Console.WriteLine(line);
        }
    }
}
