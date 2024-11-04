using Prism.Mvvm;
using Prism.Regions;

namespace Modules.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Module App Config ";
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
