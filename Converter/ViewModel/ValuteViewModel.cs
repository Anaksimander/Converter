using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Converter.Model;

namespace Converter.ViewModel
{
    public class ValuteViewModel : INotifyPropertyChanged
    {
        private Valute selectedLeftValute;
        private Valute selectedRightValute;
        public Valute SelectedLeftValute { 
            get { return selectedLeftValute; } 
            set {
                selectedLeftValute = value;
                OnPropertyChanged("SelectedLeftValute");
            } 
        }
        public Valute SelectedRightValute { 
            get { return selectedRightValute; } 
            set {
                selectedRightValute = value;
                OnPropertyChanged("SelectedRightValute");
            } 
        }

        public ObservableCollection<Valute> Valutes { get; set; }

        public ValuteViewModel()
        {
            //GetValutes();
            //Thread.Sleep(4000);
            Valutes = new ObservableCollection<Valute>()
            {
                new Valute()
                {
                    ID ="1",
                    Name = "доллар",
                    CharCode = "USD"
                },
                new Valute()
                {
                    ID ="1",
                    Name = "Австралийский доллар",
                    CharCode = "AUD"
                }
            };
        }

        public ValuteViewModel(ObservableCollection<Valute> valutes)
        {
            Valutes = valutes;
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
