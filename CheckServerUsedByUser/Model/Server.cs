﻿using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;

namespace CheckServerUsedByUser.Model
{
    /// <summary>
    /// Server, which we will check
    /// </summary>
    internal sealed class Server
    {
        private IPAddress _ipAddress;
        public IPAddress IPAddress
        {
            get => _ipAddress;
            set
            {
                _ipAddress = value;
                OnPropertyChanged(nameof(IPAddress));
            }
        }

        private User _activeUser;
        public User ActiveUser
        {
            get => _activeUser;
            set
            {
                _activeUser = value;
                OnPropertyChanged(nameof(ActiveUser));
            }
        }

        public TimeSpan IdleTime { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public bool UserIsActive(LoggedUser user)
        {
            return false;
        }
    }
}