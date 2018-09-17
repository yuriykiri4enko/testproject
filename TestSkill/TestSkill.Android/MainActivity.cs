using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TestSkill.Core;
using MvvmCross.Forms.Platforms.Android.Views;
using TestSkill.UI;

namespace TestSkill.Droid
{
    [Activity(Label = "SetupMvvmCross", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true,  ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxFormsAppCompatActivity<Setup, CoreApp, FormsApp>
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }

    }
}