using Kundenverwaltung.Data.Models;
using LinqToDB;
using LinqToDB.Data;

namespace Kundenverwaltung.Data
{
    public class Database : DataConnection
    {
        public Database():
            base("Database")
        {
            try
            {
                this.CreateTable<Kunde>();
            }
            catch 
            {
                // tabelle gibts schon
            }
        }

        public ITable<Kunde> Kunden => GetTable<Kunde>();
    }
}
