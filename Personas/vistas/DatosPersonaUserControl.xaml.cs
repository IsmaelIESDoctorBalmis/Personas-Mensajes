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

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para DatosPersonaUserControl.xaml
    /// </summary>
    public partial class DatosPersonaUserControl : UserControl
    {
        private DatosPersonaVM vm;

        public DatosPersonaUserControl()
        {
            InitializeComponent();
            vm = new DatosPersonaVM();
            this.DataContext = vm;
        }
    }
}
