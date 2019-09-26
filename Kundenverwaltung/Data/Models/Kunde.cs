using System;

namespace Kundenverwaltung.Data.Models
{
    [Serializable]
    public class Kunde
    {
        public int Id { get; set; }
        
        public string Firmenname { get; set; }
        
        public string Ansprechpartner { get; set; }
        
        public string PLZ { get; set; }
        
        public string Ort { get; set; }
    }
}
