﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CheckServerUsedByUser.Model
{
    /// <summary>
    /// User, whom we will check
    /// </summary>
    internal sealed class LoggedUser : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private Server _server;
        public Server Server
        {
            get => _server;
            set
            {
                _server = value;
                OnPropertyChanged(nameof(Server));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}