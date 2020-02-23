using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace II_Zjazd_Framework_v2
{
    //[Table("Wyklady")]
    public class Zajecia
    {
        [Key] // klucz
        public int Id { get; set; }
        [Required] // konieczne
        [Column("NazwaPrzedmiotu")]
        [MinLength(1)]
        public string Nazwa { get; set; }
        public string Sala { get; set; }
        public DateTime Godzina { get; set; }
        public int IloscObecnych { get; set; }
        [NotMapped]
        public int Haslo { get; set; }
    }
}
