using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClassWork_26_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isButtonEnabled;

        public MainWindow()
        {
            InitializeComponent();

            CommandBinding bind = new CommandBinding(ApplicationCommands.Open);
            bind.Executed += Bind_Executed;
            bind.CanExecute += Bind_CanExecute;
            this.CommandBindings.Add(bind);

            CommandBinding checkBoxBind = new CommandBinding(MyCommands.ChangeButtonStatus);
            checkBoxBind.Executed += CheckBox_Executed;
            this.CommandBindings.Add(checkBoxBind);
        }

        private void CheckBox_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.isButtonEnabled = !this.isButtonEnabled;
        }

        private void Bind_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            new MainWindow().ShowDialog();
        }

        private void Bind_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //e.CanExecute = (bool)myCheckBox.IsChecked;

            e.CanExecute = this.isButtonEnabled;
        }
    }

    public static class MyCommands
    {
        public static RoutedCommand ChangeButtonStatus { get; set; }

        static MyCommands()
        {
            ChangeButtonStatus = new RoutedCommand(nameof(ChangeButtonStatus), typeof(Window));
        }
    }
}
