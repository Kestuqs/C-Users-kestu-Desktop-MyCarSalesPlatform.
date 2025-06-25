using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MyCarSalesPlatform.Core.Models
{
    public class Listing
    {
        public int Id { get; set; }
        [Required]
        public string Pavadinimas { get; set; }
        public string Aprasymas { get; set; }
        [Required]
        public decimal Kaina { get; set; }
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Metai { get; set; }
        public string Rida { get; set; }
        public string Spalva { get; set; }
        public string Variklis { get; set; }
        public string KuroTipas { get; set; }
        public string PavarųDėžė { get; set; }
        public string Nuotraukos { get; set; }
        public DateTime Sukurtas { get; set; } = DateTime.Now;
    }
}
