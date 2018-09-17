using MvvmCross.IoC;
using MvvmCross.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TestSkill.Core.ViewModels;

namespace TestSkill.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<IntroPageViewModel>();


        }


        private static SQLiteAsyncConnection sqlConnection;
        public static SQLiteAsyncConnection SqlConnection
        {
            get
            {
                if (sqlConnection == null)
                {
                    sqlConnection = new SQLiteAsyncConnection(
                      Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SunSetLocalDB.db3"));
                }
                return sqlConnection;
            }
        }
    }
}
