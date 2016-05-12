using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
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

using PluginContract;

namespace TestMEF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [ImportMany]
        public IEnumerable<Lazy<IPlugin, IPluginMetadata>> ImportedPlugins { get; set; }

        public string PluginCall
        {
            get
            {
                return this.ImportedPlugins.Where(v => v.Metadata.PluginName == "HelloWorld").Select(v => v.Value).Single().GetName();
            }
        }

        [Import]
        public String PluginPropertyName { get; set; }

        public MainWindow()
        {
            //MEF Composition happens here
            //To see more : https://msdn.microsoft.com/en-us/magazine/ee291628.aspx
            var catalog = new DirectoryCatalog(@".\");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            InitializeComponent();
        }
    }
}
