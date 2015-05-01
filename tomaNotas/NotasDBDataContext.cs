using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace tomaNotas
{
    public class NotasDBDataContext : DataContext
    {
        public NotasDBDataContext(string connectionString)
            : base(connectionString)
        { }

        // Specify a table for the to-do items.
        public Table<Notas> Items;
    }
}
