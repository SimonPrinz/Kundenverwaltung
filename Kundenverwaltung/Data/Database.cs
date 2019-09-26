using Kundenverwaltung.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kundenverwaltung.Data
{
    public class Database
    {
        public IList<Kunde> Kunden { get; set; }

        public string FileName;

        public Database(string pFileName)
        {
            FileName = pFileName;

            Kunden = new List<Kunde>();
        }

        public int LastKundenID()
            => Kunden.Count == 0 ? 0 : Kunden.Max(i => i.Id);

        public bool Load()
        {
            if (!File.Exists(FileName))
            {
                Kunden = new List<Kunde>();
                return true;
            }

            try
            {
                BinaryFormatter lFormatter = new BinaryFormatter();
                using (FileStream tStream = new FileStream(FileName, FileMode.Open, FileAccess.Read))
                {
                    DatabaseTables lTables = (DatabaseTables)lFormatter.Deserialize(tStream);
                    Kunden = lTables.Kunden;
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool Save()
        {
            try
            {
                BinaryFormatter lFormatter = new BinaryFormatter();
                using (FileStream tStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    DatabaseTables lTables = new DatabaseTables
                    {
                        Kunden = Kunden
                    };
                    lFormatter.Serialize(tStream, lTables);
                    tStream.Flush();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        [Serializable]
        private struct DatabaseTables
        {
            public IList<Kunde> Kunden;
        }
    }
}
