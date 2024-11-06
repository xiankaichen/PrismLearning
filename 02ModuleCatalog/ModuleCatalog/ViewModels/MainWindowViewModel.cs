using Prism.Mvvm;

namespace ModuleCatalog.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism ModuleCatalog";
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
