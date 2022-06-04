using Windows.UI.Xaml.Controls;
using Converter.Model;
using Converter.ViewModel;


// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Converter.View
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class ChoiceView : Page
    {
        public ChoiceView()
        {
            //Valute selectedValute
            this.InitializeComponent();
        }
    }
}
