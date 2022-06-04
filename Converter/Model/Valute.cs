using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Model
{
    public class Valute : INotifyPropertyChanged
    {
        public string ID { get; set; }
        public string NumCode { get; set; }
        private string _charCode;
        public string CharCode {
            get
            {
                return _charCode;
            }
            set
            {
                _charCode = value;
                OnPropertyChanged("Name");
            }
        }

        public int Nominal { get; set; }
        private string _name;
        public string Name {
            get
            {
                return _name;
            } 
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public double Value { get; set; }
        public double Previous { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}