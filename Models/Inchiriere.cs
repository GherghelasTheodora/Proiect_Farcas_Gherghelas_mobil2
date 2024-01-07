using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Proiect_Farcas_Gherghelas_mobil.Models
{
    public class Inchiriere
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Magazin { get; set; }

        public string Locatie { get; set; }

        public string Contact { get; set; }

        [ForeignKey("Partie")]
        public int PartieID { get; set; }

        
    }
}
