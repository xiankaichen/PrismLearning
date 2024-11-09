using System.Windows;
using System.Windows.Controls;
using Prism.Mvvm;

namespace LogSeq.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism NLog Application";
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
