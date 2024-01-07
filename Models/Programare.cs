using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Proiect_Farcas_Gherghelas_mobil.Models
{
    public class Programare
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }


        public DateTime Data { get; set; }
        //DateTimeOffset retine doar data, fara ora
        //data si ora sa fie si ora de start cu DateTime
        //trb modificat aici sa fie doar data

        public TimeSpan Ora { get; set; }

        public int NrOre { get; set; }
        [ForeignKey("Inchiriere")]
        public int InchiriereID { get; set; }

        [ForeignKey("Produs")]
        public int ProdusID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
    }
}
