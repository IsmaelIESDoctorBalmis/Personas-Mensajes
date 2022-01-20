﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Personas
{
    class ListadoPersonasUserControlVM : ObservableObject
    {
        private PersonasService servicioPersonas;

        private ObservableCollection<Persona> listaPersonas;

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { listaPersonas = value; }
        }
        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }

        public ListadoPersonasUserControlVM()
        {
            servicioPersonas = new PersonasService();
            ListaPersonas = servicioPersonas.ObtenerPersonas();

            WeakReferenceMessenger.Default.Register<ListadoPersonasUserControlVM, MensajeDatosPersona>(this, (r, m) =>
            {
                m.Reply(r.PersonaSeleccionada);
            }

            );



        }
    }
}
