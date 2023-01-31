using WpfApp.Infrastructure.Commands;
using WpfApp.Infrastructure.Commands.Base;
using WpfApp.ViewModels.Base;

namespace WpfApp.ViewModels
{
    internal class MainViewModel : ViewModel
    {
        private string? _status;
        public string? Status
        {
            get => _status;
            set => Set(ref _status, value);
        }
        private string? _text;
        public string? Text
        {
            get => _text;
            set => Set(ref _text, value);
        }
        private string? _noWhiteSpaceText;
        public string? NoWhiteSpaceText
        {
            get => _noWhiteSpaceText;
            set => Set(ref _noWhiteSpaceText, value);
        }

        public Command CleanWhiteSpaceCommand { get; }
       

        private void OnExecutedCleanWhiteSpaceCommand(object? parameter) => NoWhiteSpaceText = Text?.Replace(" ", "");
       
        public MainViewModel()
        {
            CleanWhiteSpaceCommand = new LambdaCommand(OnExecutedCleanWhiteSpaceCommand);
        }
    }
}
