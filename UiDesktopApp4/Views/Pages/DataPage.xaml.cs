using UiDesktopApp4.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace UiDesktopApp4.Views.Pages
{
    public partial class DataPage : INavigableView<DataViewModel>
    {
        public DataViewModel ViewModel { get; }

        public DataPage(DataViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
