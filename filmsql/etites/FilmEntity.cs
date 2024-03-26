using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlmLib.DataAcces.etites
{
    public class FilmEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public decimal Year { get; set; } = decimal.MinValue;
    }
}
