using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Presenters;
using TestSkill.Core;
using TestSkill.UI;

namespace TestSkill.Droid
{
    public class Setup : MvxFormsAndroidSetup<CoreApp, FormsApp>
    {
        protected override IMvxFormsPagePresenter CreateFormsPagePresenter(IMvxFormsViewPresenter viewPresenter)
        {
            var formsPresenter = base.CreateFormsPagePresenter(viewPresenter);
            Mvx.RegisterSingleton(formsPresenter);
            return formsPresenter;
        }
    }
}