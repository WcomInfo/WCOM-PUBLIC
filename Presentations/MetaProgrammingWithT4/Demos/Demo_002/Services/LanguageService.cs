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

using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Demo_002.Services
{
    sealed class LanguageService : ILanguageService
    {
        readonly ILookup<RegionInfo, CultureInfo> m_allRegions;

        public LanguageService()
        {
            var allCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            m_allRegions = allCultures
                .Where(ci => !ci.IsNeutralCulture)
                .Where (ci => ci.LCID != 0x7F)
                .ToLookup (ci => new RegionInfo(ci.LCID))
                ;
        }

        public IEnumerable<RegionInfo> AllRegions
        {
            get { return m_allRegions.Select(g => g.Key); }
        }

        public IEnumerable<CultureInfo> GetAllCulturesInRegion(RegionInfo region)
        {
            if (region == null)
            {
                return new CultureInfo[0];
            }
            return m_allRegions[region];
        }
    }

    interface ILanguageService
    {
        IEnumerable<RegionInfo> AllRegions { get; }

        IEnumerable<CultureInfo> GetAllCulturesInRegion(RegionInfo region);
    }
}
