using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel()
        {
            OpenCommandA = new DelegateCommand(() =>
            {
                string time = DateTime.Now.ToString("HH:mm:ss ");
                Message = time + "Update View A Mesage by CommandA\r\n" + Message;
            });

            OpenCommandB = new DelegateCommand(() =>
            {
                string time = DateTime.Now.ToString("HH:mm:ss ");
                Message = time + "Update View A Mesage by CommandB \r\n"+ Message;
            });

            OpenAllCommand = new CompositeCommand();
            OpenAllCommand.RegisterCommand(OpenCommandA);
            OpenAllCommand.RegisterCommand(OpenCommandB);
        }

        public DelegateCommand OpenCommandA { get; private set; }
        public DelegateCommand OpenCommandB { get; private set; }

        public CompositeCommand OpenAllCommand { get; private set; }
    }
}
