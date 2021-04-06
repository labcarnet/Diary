using Diary.Commands;
using Diary.Models.Domains;
using Diary.Models.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
namespace Diary.ViewModels
{
    class EditSettingsViewModel : ViewModelBase
    {
        private ConnectionConfig _connectionConfig;

        public EditSettingsViewModel(ConnectionConfig connectionConfig = null)
        {
            CloseSettingsCommand = new RelayCommand(Close);
            ConfirmSettingsCommand = new RelayCommand(Confirm);

            _connectionConfig = GetConnectionConfig();
        }

        
        public ICommand CloseSettingsCommand { get; set; }
        public ICommand ConfirmSettingsCommand { get; set; }

        
        
        public ConnectionConfig ConnectionConfig
        {
            get { return _connectionConfig;  }
            set
            {
                _connectionConfig = value;
                OnPropertyChanged();
            }
        }
        
        public ConnectionConfig GetConnectionConfig()
        {
            var conncectionConfig = new ConnectionConfig();
            conncectionConfig.ServerAdress = Properties.Settings.Default.serverAdress;
            conncectionConfig.ServerName = Properties.Settings.Default.serverName;
            conncectionConfig.DataBaseName = Properties.Settings.Default.dataBaseName;
            conncectionConfig.UserId = Properties.Settings.Default.userId;
            conncectionConfig.Password = Properties.Settings.Default.password;
            return conncectionConfig;
        }

        public void SetConnectionConfig()
        {
            Properties.Settings.Default.serverAdress = _connectionConfig.ServerAdress;
            Properties.Settings.Default.serverName = _connectionConfig.ServerName;
            Properties.Settings.Default.dataBaseName = _connectionConfig.DataBaseName;
            Properties.Settings.Default.userId = _connectionConfig.UserId;
            Properties.Settings.Default.password = _connectionConfig.Password;
            Properties.Settings.Default.Save();
        }

        private void Confirm(object obj)
        {
            SetConnectionConfig();
            CloseWindow(obj as Window);

            RestartApp();
        }

        private void Close(object obj)
        {
            CloseWindow(obj as Window);
        }

        private void CloseWindow(Window window)
        {
            window.Close();
        }

        private void RestartApp()
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
    }
}
