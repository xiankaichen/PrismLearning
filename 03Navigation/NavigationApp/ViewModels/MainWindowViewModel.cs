using Prism.Mvvm;

namespace NavigationApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Navigation Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
