using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_WPFAndMVVM1.ViewModel
{
    // MainViewModel inherits from the INotifyPropertyChanged interface
    public class MainViewModel : INotifyPropertyChanged
    {
		private string myLabelText = "Text not set yet";

		public string MyLabelText
		{
			get { return myLabelText; }
			set { 
				myLabelText = value;
				OnPropertyChanged("MyLabelText");
			}
		}

		private string myTextBoxText = "Text not set yet";

		public string MyTextBoxText
		{
			get { return myTextBoxText; }
			set { 
				myTextBoxText = value;
                OnPropertyChanged("MyTextBoxText");
            }
		}

        // Implementing OnPropertyChanged helt method for the INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if(propertyChanged != null) {
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}



	}
}
