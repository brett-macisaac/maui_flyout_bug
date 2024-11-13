using System.Windows.Input;

namespace flyout_bug_tester
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
