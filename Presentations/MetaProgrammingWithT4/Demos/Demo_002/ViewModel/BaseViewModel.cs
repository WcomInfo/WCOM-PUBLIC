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

// ReSharper disable InconsistentNaming

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Demo_002.Internal;

namespace Demo_002.ViewModel
{
    abstract class BaseViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        protected void RaisePropertyChanged (string propertyName)
        {
            if (!OnPropertyChanged(propertyName ?? ""))
            {
                return;
            }

            var handler = PropertyChanged;
            if (handler != null && !propertyName.IsNullOrEmpty())
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        protected virtual bool OnPropertyChanged(string propertyName)
        {
            return true;
        }


        public event PropertyChangedEventHandler PropertyChanged;


        public bool TestIfValid()
        {
            return OnTestIfValid();
        }

        public string GetErrorInfo()
        {
            var errors = new List<string>(16);

            OnGetErrorInfo(errors);

            if (errors.Count == 0)
            {
                return null;
            }

            return string.Join("\r\n", errors.Distinct());
        }

        public string GetErrorInfo(string columnName)
        {
            return OnGetErrorInfo(columnName ?? "");
        }


        public sealed override string ToString()
        {
            var sb = new StringBuilder("{type = ");
            sb.Append(GetType().Name);

            OnToString(sb);

            sb.Append("}");

            return sb.ToString();
        }

        protected virtual void OnGetErrorInfo(List<string> errors)
        {

        }

        protected virtual string OnGetErrorInfo(string columnName)
        {
            return null;
        }

        protected virtual void OnToString(StringBuilder sb)
        {

        }

        protected virtual bool OnTestIfValid()
        {
            return true;
        }


        string IDataErrorInfo.this[string columnName]
        {
            get { return GetErrorInfo(columnName); }
        }

        string IDataErrorInfo.Error
        {
            get { return GetErrorInfo(); }
        }

    }
}
