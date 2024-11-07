using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;

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

        private string _inparam = "传入给对话框的参数：10，20，30";
        public string InParam
        {
            get { return _inparam; }
            set
            {
                _inparam = value;
                RaisePropertyChanged();
            }
        }
        private string _outparam;
        public string OutParam
        {
            get { return _outparam; }
            set
            {
                _outparam = value;
                RaisePropertyChanged();
            }
        }

        public IDialogService _dialogService;
        public DelegateCommand OpenDialogCommand { get; private set; }

        public ViewAViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            OpenDialogCommand = new DelegateCommand(OnOpenDialogCommand);
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

        public void OnOpenDialogCommand()
        {
            DialogParameters param = new DialogParameters();
            param.Add("message", InParam);
            _dialogService.ShowDialog("MsgDialog", param, r =>
            {
                if (r.Result == ButtonResult.OK)
                {
                    var result = r.Parameters.GetValue<string>("result");
                    OutParam = result;
                }
            });
        }
    }
}
