using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaksaTest.Database
{
    [Table("pretplatnici_ep", Schema = "public")]
    public class Pretplatnik_EP
    {
        [MaxLength(256)]
        public string sleptvn { get; set; }
        [Key]
        [MaxLength(16)]
        public string nkljuc { get; set; }
        [MaxLength(1)]
        public string pvpri { get; set; }
        [MaxLength(8)]
        public string ckime { get; set; }
        [MaxLength(5)]
        public string npbroj { get; set; }
        [MaxLength(3)]
        public string nreon { get; set; }
        [MaxLength(3)]
        public string ncent { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ndatpr { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ndatod { get; set; }
        [MaxLength(2)]
        public string fduzime { get; set; }
        [MaxLength(2)]
        public string fduzul { get; set; }
        [MaxLength(28)]
        public string cupime { get; set; }
        [MaxLength(30)]
        public string cupadr { get; set; }
        [MaxLength(13)]
        public string fsinas { get; set; }
        public decimal? ffedug { get; set; }
        [Column(TypeName = "date")]
        public DateTime? pdatd { get; set; }
        public decimal? ffetuz { get; set; }
        [MaxLength(1)]
        public string cpltur { get; set; }
        [MaxLength(7)]
        public string ffebpn { get; set; }
        public decimal? ffenal { get; set; }
        public decimal? ffeizv { get; set; }
        public decimal? ffetrop { get; set; }
        public decimal? ffetrnl { get; set; }
        public decimal? ffetriz { get; set; }
        [MaxLength(4)]
        public string bind_2 { get; set; }
        [MaxLength(3)]
        public string ebrizvr { get; set; }
        public bool epkodf { get; set; }
        [MaxLength(1)]
        public string razliz { get; set; }
        [MaxLength(6)]
        public string brpred { get; set; }
        [MaxLength(18)]
        public string cposnaz { get; set; }
        [MaxLength(3)]
        public string coperid { get; set; }
    }

    //[Table("Korisnici", Schema = "public")]
    //public class Korisnik
    //{
    //    [Key]
    //    public int ID { get; set; }
    //    public string Ime { get; set; }
    //    public string Prezime { get; set; }
    //    public string Jmbg { get; set; }
    //    public string Entitet { get; set; }
    //    public int Zip { get; set; }
    //    public string Grad { get; set; }
    //    public string Mjesto { get; set; }
    //    public string Adresa { get; set; }
    //    public int Status { get; set; }
    //    public DateTime Registrovan { get; set; }
    //    public decimal Osnova { get; set; }
    //    //
    //    public virtual ICollection<Kartica> Kartice { get; set; }
    //}

    //[Table("Kartice", Schema = "public")]
    //public class Kartica
    //{
    //    [Key]
    //    public int ID { get; set; }
    //    public int Godina { get; set; }
    //    public int Mjesec { get; set; }
    //    public decimal? Uplaceno { get; set; }
    //    public DateTime? DatumUplate { get; set; }
    //    //
    //    public virtual Korisnik Korisnik { get; set; }
    //}
}
