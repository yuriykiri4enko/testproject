using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestSkill.Core.API.Models;

namespace TestSkill.Core.API.Interfaces
{
    public interface IMoviesService 
    {
        Task<List<Movie>> GetTestModelAsync(string url);
    }
}
