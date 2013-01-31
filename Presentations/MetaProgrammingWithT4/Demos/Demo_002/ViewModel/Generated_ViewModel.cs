using System.Globalization;
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
using System.Globalization;


// ############################################################################
// #                                                                          #
// #        ---==>  T H I S  F I L E  I S   G E N E R A T E D  <==---         #
// #                                                                          #
// # This means that any edits to the .cs file will be lost when its          #
// # regenerated. Changes should instead be applied to the corresponding      #
// # template file (.tt)                                                      #
// ############################################################################




// ReSharper disable ExpressionIsAlwaysNull
// ReSharper disable InconsistentNaming
// ReSharper disable InvocationIsSkipped
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantOverridenMember
// ReSharper disable RedundantUsingDirective

namespace Demo_002.ViewModel
{    
    using System.Text;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    partial class CreateUserViewModel : BaseViewModel
    {
        // --------------------------------------------------------------------
        public string CreateUser_Error
        {
            get
            {
                return m_pCreateUser_Error;
            }
            set
            {
                var oldValue = m_pCreateUser_Error;
                if (oldValue != value)
                {
                    m_pCreateUser_Error = value;
                    Changed__CreateUser_Error(oldValue, value);
                    RaisePropertyChanged__CreateUser_Error ();
                }
            }
        }

        public string GetErrorInfo__CreateUser_Error()
        {
            string errorInfo = null;
            ErrorInfo__CreateUser_Error (m_pCreateUser_Error, ref errorInfo);
            return errorInfo;
        }
        // --------------------------------------------------------------------
        string m_pCreateUser_Error = default (string);
        // --------------------------------------------------------------------
        void RaisePropertyChanged__CreateUser_Error ()
        {
            RaisePropertyChanged ("CreateUser_Error");
        }
        // --------------------------------------------------------------------
        partial void Changed__CreateUser_Error (string oldValue, string newValue);
        partial void ErrorInfo__CreateUser_Error (string value, ref string errorInfo);
        // --------------------------------------------------------------------

        // --------------------------------------------------------------------
        public string CreateUser_UserName
        {
            get
            {
                return m_pCreateUser_UserName;
            }
            set
            {
                var oldValue = m_pCreateUser_UserName;
                if (oldValue != value)
                {
                    m_pCreateUser_UserName = value;
                    Changed__CreateUser_UserName(oldValue, value);
                    RaisePropertyChanged__CreateUser_UserName ();
                }
            }
        }

        public string GetErrorInfo__CreateUser_UserName()
        {
            string errorInfo = null;
            ErrorInfo__CreateUser_UserName (m_pCreateUser_UserName, ref errorInfo);
            return errorInfo;
        }
        // --------------------------------------------------------------------
        string m_pCreateUser_UserName = default (string);
        // --------------------------------------------------------------------
        void RaisePropertyChanged__CreateUser_UserName ()
        {
            RaisePropertyChanged ("CreateUser_UserName");
        }
        // --------------------------------------------------------------------
        partial void Changed__CreateUser_UserName (string oldValue, string newValue);
        partial void ErrorInfo__CreateUser_UserName (string value, ref string errorInfo);
        // --------------------------------------------------------------------

        // --------------------------------------------------------------------
        public string CreateUser_FirstName
        {
            get
            {
                return m_pCreateUser_FirstName;
            }
            set
            {
                var oldValue = m_pCreateUser_FirstName;
                if (oldValue != value)
                {
                    m_pCreateUser_FirstName = value;
                    Changed__CreateUser_FirstName(oldValue, value);
                    RaisePropertyChanged__CreateUser_FirstName ();
                }
            }
        }

        public string GetErrorInfo__CreateUser_FirstName()
        {
            string errorInfo = null;
            ErrorInfo__CreateUser_FirstName (m_pCreateUser_FirstName, ref errorInfo);
            return errorInfo;
        }
        // --------------------------------------------------------------------
        string m_pCreateUser_FirstName = default (string);
        // --------------------------------------------------------------------
        void RaisePropertyChanged__CreateUser_FirstName ()
        {
            RaisePropertyChanged ("CreateUser_FirstName");
        }
        // --------------------------------------------------------------------
        partial void Changed__CreateUser_FirstName (string oldValue, string newValue);
        partial void ErrorInfo__CreateUser_FirstName (string value, ref string errorInfo);
        // --------------------------------------------------------------------

        // --------------------------------------------------------------------
        public string CreateUser_LastName
        {
            get
            {
                return m_pCreateUser_LastName;
            }
            set
            {
                var oldValue = m_pCreateUser_LastName;
                if (oldValue != value)
                {
                    m_pCreateUser_LastName = value;
                    Changed__CreateUser_LastName(oldValue, value);
                    RaisePropertyChanged__CreateUser_LastName ();
                }
            }
        }

        public string GetErrorInfo__CreateUser_LastName()
        {
            string errorInfo = null;
            ErrorInfo__CreateUser_LastName (m_pCreateUser_LastName, ref errorInfo);
            return errorInfo;
        }
        // --------------------------------------------------------------------
        string m_pCreateUser_LastName = default (string);
        // --------------------------------------------------------------------
        void RaisePropertyChanged__CreateUser_LastName ()
        {
            RaisePropertyChanged ("CreateUser_LastName");
        }
        // --------------------------------------------------------------------
        partial void Changed__CreateUser_LastName (string oldValue, string newValue);
        partial void ErrorInfo__CreateUser_LastName (string value, ref string errorInfo);
        // --------------------------------------------------------------------

        // --------------------------------------------------------------------
        public RegionInfo CreateUser_Region
        {
            get
            {
                return m_pCreateUser_Region;
            }
            set
            {
                var oldValue = m_pCreateUser_Region;
                if (oldValue != value)
                {
                    m_pCreateUser_Region = value;
                    Changed__CreateUser_Region(oldValue, value);
                    RaisePropertyChanged__CreateUser_Region ();
                }
            }
        }

        public string GetErrorInfo__CreateUser_Region()
        {
            string errorInfo = null;
            ErrorInfo__CreateUser_Region (m_pCreateUser_Region, ref errorInfo);
            return errorInfo;
        }
        // --------------------------------------------------------------------
        RegionInfo m_pCreateUser_Region = default (RegionInfo);
        // --------------------------------------------------------------------
        void RaisePropertyChanged__CreateUser_Region ()
        {
            RaisePropertyChanged ("CreateUser_Region");
        }
        // --------------------------------------------------------------------
        partial void Changed__CreateUser_Region (RegionInfo oldValue, RegionInfo newValue);
        partial void ErrorInfo__CreateUser_Region (RegionInfo value, ref string errorInfo);
        // --------------------------------------------------------------------

        // --------------------------------------------------------------------
        public CultureInfo CreateUser_Culture
        {
            get
            {
                return m_pCreateUser_Culture;
            }
            set
            {
                var oldValue = m_pCreateUser_Culture;
                if (oldValue != value)
                {
                    m_pCreateUser_Culture = value;
                    Changed__CreateUser_Culture(oldValue, value);
                    RaisePropertyChanged__CreateUser_Culture ();
                }
            }
        }

        public string GetErrorInfo__CreateUser_Culture()
        {
            string errorInfo = null;
            ErrorInfo__CreateUser_Culture (m_pCreateUser_Culture, ref errorInfo);
            return errorInfo;
        }
        // --------------------------------------------------------------------
        CultureInfo m_pCreateUser_Culture = default (CultureInfo);
        // --------------------------------------------------------------------
        void RaisePropertyChanged__CreateUser_Culture ()
        {
            RaisePropertyChanged ("CreateUser_Culture");
        }
        // --------------------------------------------------------------------
        partial void Changed__CreateUser_Culture (CultureInfo oldValue, CultureInfo newValue);
        partial void ErrorInfo__CreateUser_Culture (CultureInfo value, ref string errorInfo);
        // --------------------------------------------------------------------

        // --------------------------------------------------------------------
        public RegionInfo[] CreateUser_Regions
        {
            get
            {
                RegionInfo[] value = default (RegionInfo[]);
                Compute__CreateUser_Regions (ref value);
                return value;
            }
        }
        // --------------------------------------------------------------------
        void RaisePropertyChanged__CreateUser_Regions ()
        {
            RaisePropertyChanged ("CreateUser_Regions");
        }
        // --------------------------------------------------------------------
        partial void Compute__CreateUser_Regions (ref RegionInfo[] newValue);
        // --------------------------------------------------------------------

        // --------------------------------------------------------------------
        public CultureInfo[] CreateUser_Cultures
        {
            get
            {
                return m_pCreateUser_Cultures;
            }
            private set
            {
                var oldValue = m_pCreateUser_Cultures;
                if (oldValue != value)
                {
                    m_pCreateUser_Cultures = value;
                    Changed__CreateUser_Cultures(oldValue, value);
                    RaisePropertyChanged__CreateUser_Cultures ();
                }
            }
        }

        public string GetErrorInfo__CreateUser_Cultures()
        {
            string errorInfo = null;
            ErrorInfo__CreateUser_Cultures (m_pCreateUser_Cultures, ref errorInfo);
            return errorInfo;
        }
        // --------------------------------------------------------------------
        CultureInfo[] m_pCreateUser_Cultures = default (CultureInfo[]);
        // --------------------------------------------------------------------
        void RaisePropertyChanged__CreateUser_Cultures ()
        {
            RaisePropertyChanged ("CreateUser_Cultures");
        }
        // --------------------------------------------------------------------
        partial void Changed__CreateUser_Cultures (CultureInfo[] oldValue, CultureInfo[] newValue);
        partial void ErrorInfo__CreateUser_Cultures (CultureInfo[] value, ref string errorInfo);
        // --------------------------------------------------------------------


        protected override void OnToString(StringBuilder sb)
        {
            sb.Append (", CreateUser_Error = '");
            sb.Append (CreateUser_Error);
            sb.Append ("'");
            sb.Append (", CreateUser_UserName = '");
            sb.Append (CreateUser_UserName);
            sb.Append ("'");
            sb.Append (", CreateUser_FirstName = '");
            sb.Append (CreateUser_FirstName);
            sb.Append ("'");
            sb.Append (", CreateUser_LastName = '");
            sb.Append (CreateUser_LastName);
            sb.Append ("'");
            sb.Append (", CreateUser_Region = '");
            sb.Append (CreateUser_Region);
            sb.Append ("'");
            sb.Append (", CreateUser_Culture = '");
            sb.Append (CreateUser_Culture);
            sb.Append ("'");
            sb.Append (", CreateUser_Regions = '");
            sb.Append (CreateUser_Regions);
            sb.Append ("'");
            sb.Append (", CreateUser_Cultures = '");
            sb.Append (CreateUser_Cultures);
            sb.Append ("'");

            sb.Append ("}");
        }


        protected override string OnGetErrorInfo(string columnName)
        {
            switch(columnName)
            {
            case "CreateUser_Error":
                return GetErrorInfo__CreateUser_Error();
            case "CreateUser_UserName":
                return GetErrorInfo__CreateUser_UserName();
            case "CreateUser_FirstName":
                return GetErrorInfo__CreateUser_FirstName();
            case "CreateUser_LastName":
                return GetErrorInfo__CreateUser_LastName();
            case "CreateUser_Region":
                return GetErrorInfo__CreateUser_Region();
            case "CreateUser_Culture":
                return GetErrorInfo__CreateUser_Culture();
            case "CreateUser_Cultures":
                return GetErrorInfo__CreateUser_Cultures();
            default:
                return base.OnGetErrorInfo(columnName);
            }
        }

        protected override bool OnTestIfValid()
        {
            {
                var errorInfo = GetErrorInfo__CreateUser_Error();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    return false;
                }
            }
            {
                var errorInfo = GetErrorInfo__CreateUser_UserName();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    return false;
                }
            }
            {
                var errorInfo = GetErrorInfo__CreateUser_FirstName();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    return false;
                }
            }
            {
                var errorInfo = GetErrorInfo__CreateUser_LastName();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    return false;
                }
            }
            {
                var errorInfo = GetErrorInfo__CreateUser_Region();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    return false;
                }
            }
            {
                var errorInfo = GetErrorInfo__CreateUser_Culture();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    return false;
                }
            }
            {
                var errorInfo = GetErrorInfo__CreateUser_Cultures();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    return false;
                }
            }
            return base.OnTestIfValid();
        }

        protected override void OnGetErrorInfo(List<string> errors)
        {
            {
                var errorInfo = GetErrorInfo__CreateUser_Error();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    errors.Add (errorInfo);
                }
            }
            {
                var errorInfo = GetErrorInfo__CreateUser_UserName();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    errors.Add (errorInfo);
                }
            }
            {
                var errorInfo = GetErrorInfo__CreateUser_FirstName();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    errors.Add (errorInfo);
                }
            }
            {
                var errorInfo = GetErrorInfo__CreateUser_LastName();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    errors.Add (errorInfo);
                }
            }
            {
                var errorInfo = GetErrorInfo__CreateUser_Region();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    errors.Add (errorInfo);
                }
            }
            {
                var errorInfo = GetErrorInfo__CreateUser_Culture();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    errors.Add (errorInfo);
                }
            }
            {
                var errorInfo = GetErrorInfo__CreateUser_Cultures();
                if (!string.IsNullOrWhiteSpace(errorInfo))
                {
                    errors.Add (errorInfo);
                }
            }
        }

    }
   


}


