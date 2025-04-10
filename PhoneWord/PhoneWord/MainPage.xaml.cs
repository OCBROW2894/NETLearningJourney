using Phoneword;

namespace PhoneWord
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        string? translatedNumber;

        private void OnTranslate(object sender, EventArgs e)
        {
            string enteredNumber = PhoneNumberText.Text;
            translatedNumber = PhonewordTranslator.ToNumber(enteredNumber);

            if (!string.IsNullOrEmpty(translatedNumber))
            {
                // TODO:
            }
            else
            {
                // TODO:
            }
        }
    }
}
