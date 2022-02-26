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

namespace Jennet.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string FilePath = string.Join(" ", Environment.GetCommandLineArgs().Skip(1).ToArray());
            if (!string.IsNullOrEmpty(FilePath))
            {
                string FileContent = System.IO.File.ReadAllText(FilePath);
                textBox.Text = FileContent;
            }
        }
    }
}
