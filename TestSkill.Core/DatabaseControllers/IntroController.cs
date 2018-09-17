using System;
using System.Collections.Generic;
using System.Text;
using TestSkill.Core.API.Models;

namespace TestSkill.Core.DatabaseControllers
{
    public class IntroController<T> : EntityController<T> where T : BaseEntity, new()
    {
        public IntroController() : base(CoreApp.SqlConnection)
        {
            CoreApp.SqlConnection.CreateTableAsync<Movie>().Wait();
        }
    }
}


