using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace firstapp
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public HomePageViewModel()
        {
            Message = "Well done!";
        }

        public string Message { get; set; }

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
