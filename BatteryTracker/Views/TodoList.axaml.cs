using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace BatteryTracker.Views
{
    public class TodoList : UserControl
    {
        public TodoList()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}