using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Proiect_Farcas_Gherghelas_mobil.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        [Display(Name = "Nume Complet")]
        public string NumeComplet
        {
            get
            {
                return Prenume + " " + Nume;
            }
        }
    }
}
