using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace MvvmCrossApp.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private const string DefaultText = "Hello MvvmCross";

        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);

        private void ResetText()
        {
            Text = DefaultText;
        }


        private string _text = DefaultText;
        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

    }
}
