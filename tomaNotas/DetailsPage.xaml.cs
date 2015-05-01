using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using tomaNotas.Resources;
using tomaNotas.ViewModels;

namespace tomaNotas
{
    public partial class DetailsPage : PhoneApplicationPage
    {
        private ItemViewModel ourItem;
        private int notaNumero;

        // Constructor
        public DetailsPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // When page is navigated to set data context to selected item in list
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string selectedIndex = "";
            if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
            {
                int index = int.Parse(selectedIndex);
                
                ourItem = App.ViewModel.buscarNotas(index);

                notaNumero = ourItem.NotaId;

                DataContext = ourItem;

            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("A eliminar: " + notaNumero);
            App.ViewModel.borrarNotas(notaNumero);

            NavigationService.GoBack();
        }
    }
}