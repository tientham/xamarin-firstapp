using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace firstapp
{
    public class HomePageViewModel : INotifyPropertyChanged
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

        #region Event handler

        /// <summary>
        /// Occurs when the property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        /// <summary>
        /// The PropertyChanged event occurs when changing the value of property.
        /// </summary>
        /// <param name="propertyName">The PropertyName</param>
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
