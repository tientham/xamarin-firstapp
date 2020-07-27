using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace firstapp
{
    public class MainPageViewModel: INotifyPropertyChanged
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
