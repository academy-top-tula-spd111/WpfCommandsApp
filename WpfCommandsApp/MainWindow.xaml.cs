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

namespace WpfCommandsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CommandBinding commandBinding;
        CommandBinding commandBinding2;

        public RoutedCommand MyCommand { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            MyCommand = new RoutedCommand("MyCommand", typeof(MainWindow));

            commandBinding = new();
            commandBinding.Command = ApplicationCommands.Help;
            commandBinding.Executed += HelpExecuted;

            commandBinding2 = new();
            commandBinding2.Command = ApplicationCommands.Help;
            commandBinding2.Executed += HelpExecuted2;


            btnHelp.CommandBindings.Add(commandBinding);
            btnHelp.Command = ApplicationCommands.Help;

            
        }

        private void HelpExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Help!");
        }

        private void HelpExecuted2(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Other Help!");
        }

        private void btnHelp2_Click(object sender, RoutedEventArgs e)
        {
            btnHelp.CommandBindings.Clear();
            btnHelp.CommandBindings.Add(commandBinding2);
        }
    }
}
