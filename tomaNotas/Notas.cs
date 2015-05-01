using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace tomaNotas
{
    [Table]
    public class Notas
    {
        [Column(IsPrimaryKey = true,
            IsDbGenerated = true,
            DbType = "INT NOT NULL Identity",
            CanBeNull = false,
            AutoSync = AutoSync.OnInsert)]
        public int NotaId { get; set; }

        [Column]
        public string Titulo { get; set; }

        [Column]
        public string Contenido { get; set; }

    }
}
