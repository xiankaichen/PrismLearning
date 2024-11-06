using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Prism.Mvvm;
using Prism.Regions;

namespace NavigationView.ViewModels
{
    public class ViewBViewModel:BindableBase, INavigationAware
    {
        private string message = "View B";
        public string Message
        {
            get { return message; }
            set {
                message = value;
                RaisePropertyChanged();
            }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            Message = navigationContext.Parameters["message"].ToString();
        }
    }
}
