using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{

    class DatosPersonaVM : ObservableRecipient
    {

        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }

        public DatosPersonaVM()
        {
            PersonaSeleccionada = WeakReferenceMessenger.Default.Send<MensajeDatosPersona>();

        }

        

    }
}
