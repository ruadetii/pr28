using System.Windows;
using TaskManager_Radosteva.ViewModels;

namespace TaskManager_Radosteva
{
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            init = this;
            DataContext = new VM_Pages();
        }
    }
}