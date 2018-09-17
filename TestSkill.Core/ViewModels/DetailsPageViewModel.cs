using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using TestSkill.Core.API.Models;

namespace TestSkill.Core.ViewModels
{
    public class DetailsPageViewModel : MvxViewModel<Movie>
    {
        private readonly IMvxNavigationService _navigationService;


        #region LifeCycle

        public DetailsPageViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
           

        }

        
        

        public override void Prepare(Movie parameter)
        {
            ItemMovie = parameter;
            RaisePropertyChanged(() => ItemMovie);
        }

        #endregion

        #region Property

        private Movie _itemMovie;
        public Movie ItemMovie
        {
            get => _itemMovie;
            set => SetProperty(ref _itemMovie, value);
        }

        #endregion
    }
}
