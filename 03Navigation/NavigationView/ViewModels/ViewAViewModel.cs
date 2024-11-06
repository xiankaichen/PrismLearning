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
    public class ViewAViewModel:BindableBase, INavigationAware
    {
        private string title = "View A";
        public string Title
        {
            get { return title; }
            set { title = value;
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
            Title = navigationContext.Parameters["message"].ToString();
        }
    }
}
