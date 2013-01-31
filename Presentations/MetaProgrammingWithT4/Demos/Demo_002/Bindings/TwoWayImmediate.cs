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
using System.Collections.Concurrent;
using System.Windows.Data;
using System.Windows.Markup;

namespace Demo_002.Bindings
{
    sealed class TwoWayImmediate : MarkupExtension
    {
        static readonly ConcurrentDictionary<string, Binding> s_cache = new ConcurrentDictionary<string, Binding> ();

        readonly Binding m_binding;

        public TwoWayImmediate (string path)
        {
            m_binding = s_cache.GetOrAdd(path ?? "", p => new Binding(p) { Mode = BindingMode.TwoWay, ValidatesOnDataErrors = true, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, });
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return m_binding.ProvideValue(serviceProvider);
        }
    }
}
