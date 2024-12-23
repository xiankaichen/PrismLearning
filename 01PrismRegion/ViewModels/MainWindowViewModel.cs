﻿using Prism.Mvvm;
using Prism.Regions;

namespace PrismRegion.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;
        private string _title = "Prism Region";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;

            regionManager.RegisterViewWithRegion("ContentRegionA", typeof(Views.ViewA));
            regionManager.RegisterViewWithRegion("ContentRegionB", typeof(Views.ViewB));
        }
    }
}
