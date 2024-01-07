using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Proiect_Farcas_Gherghelas_mobil.Models
{
    public class Produs
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string TipProdus { get; set; }

        [AllowNull]
        public int Marime { get; set; }
        [AllowNull]
        public int Inaltime { get; set; }

        public decimal Pret { get; set; }

        [ForeignKey("Inchiriere")]
        public int InchiriereID { get; set; }
    }
}
