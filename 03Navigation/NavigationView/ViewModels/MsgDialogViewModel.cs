using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace NavigationView.ViewModels
{
    public class MsgDialogViewModel : BindableBase, IDialogAware
    {
        public string Title { get; }
        private string _inparam;
        public string InParam
        {
            get { return _inparam; }
            set {
                _inparam = value;
                RaisePropertyChanged();
            }
        }

        private string _outParam;
        public string OutParam
        {
            get { return _outParam; }
            set
            {
                _outParam = value;
                RaisePropertyChanged();
            }
        }

        public event Action<IDialogResult> RequestClose;
        public DelegateCommand YesDialogCommand { get; private set; }
        public DelegateCommand NoDialogCommand { get; private set; }


        public MsgDialogViewModel()
        {
            YesDialogCommand = new DelegateCommand(() =>
            {
                DialogParameters param = new DialogParameters();
                param.Add("result", OutParam);
                RequestClose?.Invoke(new DialogResult(ButtonResult.OK, param));
            });
            NoDialogCommand = new DelegateCommand(() =>
            {
                RequestClose?.Invoke(new DialogResult(ButtonResult.No));
            });
        }




        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            InParam = parameters.GetValue<string>("message");
        }

        
    }
}
