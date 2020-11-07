using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using firstapp.ViewModels;
using Xamarin.Forms;

namespace firstapp
{
    public class MainPageViewModel: BaseViewModel
    {
        public MainPageViewModel()
        {
            Name = "To Minh Tien";
            ModifyNameLabelCommand = new Command(ModifyNameLabelCommandExecute);
        }

        public string Name { get; set; }

        public ICommand ModifyNameLabelCommand { get; }

        private void ModifyNameLabelCommandExecute(object obj)
        {
            Name = "Minh Tien TO";
            NotifyPropertyChanged("Name");
        }
    }
}
