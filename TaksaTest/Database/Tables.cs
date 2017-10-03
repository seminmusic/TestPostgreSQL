using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaksaTest.Database
{
    [Table("Korisnici", Schema = "public")]
    public class Korisnik
    {
        [Key]
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Jmbg { get; set; }
        public string Entitet { get; set; }
        public int Zip { get; set; }
        public string Grad { get; set; }
        public string Mjesto { get; set; }
        public string Adresa { get; set; }
        public int Status { get; set; }
        public DateTime Registrovan { get; set; }
        public decimal Osnova { get; set; }
        //
        public virtual ICollection<Kartica> Kartice { get; set; }
    }

    [Table("Kartice", Schema = "public")]
    public class Kartica
    {
        [Key]
        public int ID { get; set; }
        public int Godina { get; set; }
        public int Mjesec { get; set; }
        public decimal? Uplaceno { get; set; }
        public DateTime? DatumUplate { get; set; }
        //
        public virtual Korisnik Korisnik { get; set; }
    }
}
