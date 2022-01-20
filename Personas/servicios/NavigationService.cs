﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Personas
{
    class NavigationService
    {
        private static readonly UserControl listadoPersonas = new ListadoPersonasUserControl();
      

        public NavigationService()
        {
            
        }

        public UserControl ObtenerNuevaPersona()
        {
            return new NuevaPersonaUserControl();
        }

        public UserControl ObtenerListadoPersonas()
        {
            return listadoPersonas;
        }
        public UserControl ObtenerDatosPersonas()
        {
            return new DatosPersonaUserControl();
        }

        public bool? AbrirDialogoNacionalidad()
        {
            DialogoNacionalidad dialogo = new DialogoNacionalidad();
            return dialogo.ShowDialog();
        }
    }
}
