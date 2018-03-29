using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CheckServerUsedByUser.Model
{
    /// <summary>
    /// All work with settings and preferences will be do in this class
    /// </summary>
    internal sealed class Settings : INotifyPropertyChanged
    {
        private string _preferencesPath;
        public string PreferencesPath
        {
            get => _preferencesPath;
            set
            {
                _preferencesPath = value;
                OnPropertyChanged(nameof(PreferencesPath));
            }
        }


        // Save this file

        // Save preferences

        // Load this file

        // Load preferences

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}