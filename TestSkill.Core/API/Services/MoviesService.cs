using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestSkill.Core.API.Interfaces;
using TestSkill.Core.API.Models;
using TestSkill.Core.API.Services;

namespace TestSkill.Core.API.Services
{
    public class MoviesService : BaseApiService, IMoviesService
    {
        public async Task<List<Movie>> GetTestModelAsync(string Url)
        {
            try
            {
                var request = await ExecuteGetAsync(Url);
                var rawResponse = request.Content.ReadAsStringAsync().Result;
                var deserializeresult = JsonConvert.DeserializeObject<List<Movie>>(rawResponse);

                return deserializeresult;
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }
    }
}
