using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace ModuleB.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
            
        }

        public ViewAViewModel(IEventAggregator eventAggregator)
        {

            SubCommand = new DelegateCommand(() =>
            {
                if (!eventAggregator.GetEvent<MessageEvent>().Contains(OnMessageReceived))
                {
                    eventAggregator.GetEvent<MessageEvent>().Subscribe(OnMessageReceived);
                    Message = "订阅成功";
                }
                else
                {
                    Message = "已经订阅";
                }
                    
            });
            UnSubCommand = new DelegateCommand(() =>
            {
                eventAggregator.GetEvent<MessageEvent>().Unsubscribe(OnMessageReceived);
                Message = "取消订阅";
            });
            PubCommand = new DelegateCommand(() =>
            {
                string time = DateTime.Now.ToString("HH:mm:ss ");
                eventAggregator.GetEvent<MessageEvent>().Publish(time  + "Hello from ViewAViewModel \r\n");
            });
            ClearMssageCommand = new DelegateCommand(() =>
            {
                Message = string.Empty;
            });
        }

        public void OnMessageReceived(string msg)
        {
            Message = msg + Message;
        }

        public DelegateCommand SubCommand { get; private set; }
        public DelegateCommand UnSubCommand { get; private set; }
        public DelegateCommand PubCommand { get; private set; }
        public DelegateCommand ClearMssageCommand { get; private set; }
    }

    public class MessageEvent : PubSubEvent<string>
    {
    }
}
