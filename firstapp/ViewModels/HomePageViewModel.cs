using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using firstapp.ViewModels;
using Xamarin.Forms;

namespace firstapp
{
    public class HomePageViewModel : BaseViewModel
    {
        public HomePageViewModel()
        {
            Message = "Well done!";
            ModifyLabelCommand = new Command(ModifyLabelCommandExecute);
        }

        public string Message { get; set; }

        public ICommand ModifyLabelCommand { get; }

        private void ModifyLabelCommandExecute(object obj)
        {
            Debug.WriteLine("Someone clicks into the button");
            Message = "Hey! I am changed by someone!";
            NotifyPropertyChanged(nameof(Message));
        }
    }
}
