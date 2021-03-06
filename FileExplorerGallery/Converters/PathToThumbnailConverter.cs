﻿using FileExplorerGallery.Behaviors;
using System;
using System.Globalization;
using System.Windows.Data;

namespace FileExplorerGallery.Converters
{
    public class PathToThumbnailConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }

            return GalleryCacheProvider.GetThumbnail((string)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
