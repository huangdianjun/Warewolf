/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2018 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;


namespace Dev2.Studio.Core.AppResources.Converters
{
    public class NullToVisibilityConverter : IValueConverter
    {
        public NullToVisibilityConverter()
        {
            NullVisibilityValue = Visibility.Collapsed;
            NotNullVisibilityValue = Visibility.Visible;
        }

        public Visibility NullVisibilityValue
        {
            get;
            set;
        }

        public Visibility NotNullVisibilityValue
        {
            get;
            set;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                return NullVisibilityValue;
            }

            return NotNullVisibilityValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
