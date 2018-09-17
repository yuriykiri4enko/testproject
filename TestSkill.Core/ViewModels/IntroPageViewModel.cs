using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSkill.Core.API.Interfaces;
using TestSkill.Core.API.Models;
using TestSkill.Core.DatabaseControllers;

namespace TestSkill.Core.ViewModels
{
    public class IntroPageViewModel : MvxViewModel
    {
        #region ServiceFields
        private readonly IMvxNavigationService _navigationService;
        private readonly IMoviesService _moviesModelService;
        private IntroController<Movie> introController { get; } = new IntroController<Movie>();

        #endregion

        #region Properties
        private MvxObservableCollection<Movie> _movies;
        public MvxObservableCollection<Movie> Movies
        {
            get => _movies;
            set => SetProperty(ref _movies, value);
        }

        private Movie _listMoviesOnItemSelected;
        public Movie ListMoviesOnItemSelected
        {
            get => _listMoviesOnItemSelected;
            set
            {
                SetProperty(ref _listMoviesOnItemSelected, value);

                if(value != null)
                {
                    _navigationService.Navigate<DetailsPageViewModel, Movie>(value);
                }


            }
        }


        #endregion

        #region LifeCycle


        public IntroPageViewModel(IMvxNavigationService navigationService, IMoviesService moviesModelService)
        {
            _moviesModelService = moviesModelService;
            _navigationService = navigationService;
           
        }



        public override Task Initialize()
        {
            Task.Run(async () => {

                var result = await _moviesModelService.GetTestModelAsync(Configurations.Config.Url);

                if(result != null)
                {
                   Movies = new MvxObservableCollection<Movie>(result);
                 //  await InitialiseToDBAsync(result);
                }
            });

            return base.Initialize();
            
        }

        #endregion


    }
}
