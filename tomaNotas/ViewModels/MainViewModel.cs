using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace tomaNotas.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private NotasDBDataContext dbDataContext;

        public MainViewModel()
        {
            dbDataContext = App.DB;
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _itemsProperty = "Items Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string ItemsProperty
        {
            get
            {
                return _itemsProperty;
            }
            set
            {
                if (value != _itemsProperty)
                {
                    _itemsProperty = value;
                    NotifyPropertyChanged("ItemsProperty");
                }
            }
        }
        
        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            this.Items.Clear();

            int notaNumero = 1;
            
            var notasInDB = from Notas n in dbDataContext.Items
                             orderby  n.NotaId select n;

            // Query the database and load all to-do items.
            var AllNotas = new ObservableCollection<Notas>(notasInDB);

            foreach (Notas oneNota in AllNotas)
            {
                //
                // Create an empty ItemViewModel
                //
                ItemViewModel ivm = new ItemViewModel();

                //
                // The main item shown in the ListBox is the number
                // of the sonnet in Roman numerals
                //

                ivm.NotaId = oneNota.NotaId;

                ivm.LineOne = oneNota.Titulo;

                ivm.LineTwo = oneNota.Contenido;

                this.Items.Add(ivm);

                notaNumero++;
            }

            this.IsDataLoaded = true;
        }

        public ItemViewModel buscarNotas(int index)
        {
            var notasInDB = from Notas n in dbDataContext.Items
                            where n.NotaId == index
                            select n;
            var AllNotas = new ObservableCollection<Notas>(notasInDB);
            return new ItemViewModel() { NotaId=AllNotas[0].NotaId,LineOne=AllNotas[0].Titulo,LineTwo=AllNotas[0].Contenido};
        }
        public void borrarNotas(int index)
        {
            var notasInDB = from Notas n in dbDataContext.Items
                         where n.NotaId == index
                        select n;
            var AllNotas = new ObservableCollection<Notas>(notasInDB);
            foreach (Notas oneNota in AllNotas)
            {
                Debug.WriteLine("Eliminado: "+oneNota.NotaId);
                dbDataContext.Items.DeleteOnSubmit(oneNota);

            }

            dbDataContext.SubmitChanges();

            IsDataLoaded = false;
        }

        public void guardarNotas(Notas notas)
        {
            dbDataContext.Items.InsertOnSubmit(notas);

            dbDataContext.SubmitChanges();

            IsDataLoaded = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}