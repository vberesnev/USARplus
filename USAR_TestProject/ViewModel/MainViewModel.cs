using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using USAR_TestProject.Model;

namespace USAR_TestProject.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {

        private RelayCommand saveCommand;
        public RelayCommand SaveCommand => saveCommand;
        public void Save(object obj)
        {
            CurrentMessage.UserName = System.Environment.UserName;
            CurrentMessage.SaveDate = DateTime.Now;
            messageList.AddAsync(CurrentMessage);
            CurrentMessage = new Message();
        }

        private IMessage currentMessage;
        public IMessage CurrentMessage
        {
            get { return currentMessage; }
            set
            {
                currentMessage = value;
                OnPropertyChanged("CurrentMessage");
            }
        }

        private MessagesList messageList;
        public MainViewModel()
        {
            saveCommand = new RelayCommand(Save);
            messageList = new MessagesList();
            messageList.Load();
            if (messageList.MessageCount > 0)
                CurrentMessage = messageList.GetLastMessage();
            else
                CurrentMessage = new Message();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
