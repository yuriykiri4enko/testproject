using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Converters;
using Xamarin.Forms;

namespace TestSkill.Droid.Converters
{
    public class UrlToByteArrayConverter : MvxValueConverter<string, ImageSource>
    {
        protected override ImageSource Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {

            var webClient = new WebClient();
            byte[] imageBytes = webClient.DownloadData(value);
            
            ImageSource retSource = ImageSource.FromStream(() => new MemoryStream(imageBytes));
            return retSource;
        }

      
    }
}