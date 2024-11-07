using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationView.Views;
using Prism.Regions;
using Prism.Services.Dialogs;

namespace NavigationView.ViewModels
{
    public class ViewNavigationViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        IRegionNavigationJournal _journal;
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewNavigationViewModel(IRegionManager regionManager)
        {
            OpenViewACommand = new DelegateCommand(OnOpenViewA);
            OpenViewBCommand = new DelegateCommand(OnOpenViewB);
            OpenPrevCommand = new DelegateCommand(OnOpenPrev);
            OpenNextCommand = new DelegateCommand(OnOpenNext);

            _regionManager = regionManager;

            _regionManager.RegisterViewWithRegion("ContentRegionNavigation", "ViewA");
            _regionManager.RegisterViewWithRegion("ContentRegionNavigation", "ViewB");


        }

        public DelegateCommand OpenViewACommand { get; private set; }
        public DelegateCommand OpenViewBCommand { get; private set; }
        public DelegateCommand OpenPrevCommand { get; private set; }
        public DelegateCommand OpenNextCommand { get; private set; }

        public void OnOpenViewA()
        {
            NavigationParameters parameters = new NavigationParameters();
            string datetime = DateTime.Now.ToString();
            parameters.Add("message", datetime + " 传递了参数到页面A");
            _regionManager.RequestNavigate("ContentRegionNavigation", "ViewA", arg =>
            {
                _journal = arg.Context.NavigationService.Journal;
            }, parameters);
        }

        public void OnOpenViewB()
        {
            NavigationParameters parameters = new NavigationParameters();
            string datetime = DateTime.Now.ToString();
            parameters.Add("message", datetime + " 传递了参数到页面B");
            _regionManager.RequestNavigate("ContentRegionNavigation", "ViewB", arg =>
            {
                _journal = arg.Context.NavigationService.Journal;
            },parameters);
        }

        public void OnOpenPrev()
        {
            if (_journal == null)
                return;
            
            _journal.GoBack();
        }

        public void OnOpenNext()
        {
            if (_journal == null)
                return;
            _journal.GoForward();
        }


    }
}
