using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            Initialize();
        }

        private void Initialize()
        {

            //string filePath = string.Join(" ", Environment.GetCommandLineArgs().Skip(1).ToArray());
            string filePath = @"C:/Projects/Personal/Jennet/Jennet.Solution/Test.json";
            if (!string.IsNullOrEmpty(filePath))
            {
                string fileContent = System.IO.File.ReadAllText(filePath);
                var ocelot = JsonSerializer.Deserialize<OcelotDTO>(fileContent);
                dataGrid.DataContext = ocelot.ReRoutes;
            }
        }

    }
}
