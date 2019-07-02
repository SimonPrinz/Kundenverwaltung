using LinqToDB.Mapping;
using System.ComponentModel;

namespace Kundenverwaltung.Data.Models
{
    [Table]
    public class Kunde
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column]
        [Browsable(false)]
        public bool Deleted { get; set; }

        [Column]
        public string Firmenname { get; set; }
        [Column]
        public string Ansprechpartner { get; set; }
        [Column]
        public string PLZ { get; set; }
        [Column]
        public string Ort { get; set; }
    }
}
