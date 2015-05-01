using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace tomaNotas
{
    public partial class NuevaNota : PhoneApplicationPage
    {
        private bool editTitulo = false;
        private bool editContenido = false;
        public NuevaNota()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (boxTitulo.Text.Equals(""))
            {
                MessageBox.Show("Modifique el titulo de la nota");
            }
            else if (boxContenido.Text.Equals(""))
            {
                MessageBox.Show("Modifique el contenido de la nota");
            }
            else 
            {

                App.ViewModel.guardarNotas(new Notas
                    {
                        Titulo = boxTitulo.Text,
                        Contenido = boxContenido.Text
                    });

                NavigationService.GoBack();
            }            
        }

        private void boxContenido_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!editContenido)
            {
                boxContenido.Text = "";
                editContenido = true;
            }
        }

        private void boxTitulo_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!editTitulo)
            {
                boxTitulo.Text = "";
                editTitulo = true;
            }
        }

        
    }
}