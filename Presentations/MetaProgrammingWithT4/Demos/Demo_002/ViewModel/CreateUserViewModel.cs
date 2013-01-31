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

using System.Globalization;
using System.Linq;
using System.Windows.Input;
using Demo_002.Internal;
using Demo_002.Services;

namespace Demo_002.ViewModel
{
    sealed partial class CreateUserViewModel
    {
        readonly ILanguageService m_languageService;

        ViewModelCommand m_saveCommand;

        readonly RegionInfo[] m_regionInfos;

        public CreateUserViewModel()
        {
            m_languageService = ServiceLibrary.LanguageService;

            m_regionInfos = m_languageService
                .AllRegions
                .OrderBy(r => r.EnglishName)
                .ToArray();
        }

        partial void Changed__CreateUser_Region(RegionInfo oldValue, RegionInfo newValue)
        {
            CreateUser_Cultures = m_languageService
                .GetAllCulturesInRegion(newValue)
                .OrderBy(c => c.EnglishName)
                .ToArray();
            CreateUser_Culture = null;
        }

        partial void Compute__CreateUser_Regions(ref RegionInfo[] newValue)
        {
            newValue = m_regionInfos;
        }

        protected override bool OnPropertyChanged(string propertyName)
        {
            m_saveCommand.Raise_CanExecuteChanged();
            return base.OnPropertyChanged(propertyName);
        }

        public ICommand CreateUser_SaveCommand
        {
            get            
            {
                if (m_saveCommand == null)
                {
                    m_saveCommand = new ViewModelCommand(OnExecuteSave, OnCanExecuteSave);
                }

                return m_saveCommand;
            }


        }

        partial void ErrorInfo__CreateUser_UserName(string value, ref string errorInfo)
        {
            errorInfo = value.IsNullOrEmpty().OnTrue("User name must not be empty");
        }

        partial void ErrorInfo__CreateUser_FirstName(string value, ref string errorInfo)
        {
            errorInfo = value.IsNullOrEmpty().OnTrue("First name must not be empty");
        }

        partial void ErrorInfo__CreateUser_LastName(string value, ref string errorInfo)
        {
            errorInfo = value.IsNullOrEmpty().OnTrue("Last name must not be empty");
        }

        partial void ErrorInfo__CreateUser_Region(RegionInfo value, ref string errorInfo)
        {
            errorInfo = (value == null).OnTrue("A region must be selected");
        }

        partial void ErrorInfo__CreateUser_Culture(CultureInfo value, ref string errorInfo)
        {
            errorInfo = (value == null).OnTrue("A culture must be selected");
        }

        bool OnCanExecuteSave(object parameter)
        {
            var valid = TestIfValid();

            if (valid)
            {
                CreateUser_Error = "";
            }
            else
            {
                CreateUser_Error = GetErrorInfo();
            }

            return valid;
        }

        void OnExecuteSave(object parameter)
        {
            // DOSTUFF
        }
    }
}
