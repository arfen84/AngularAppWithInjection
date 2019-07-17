using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracje.Models
{
    public class Lokal
    {
        public String Nazwa { get; set; }
        public String Miasto { get; set; }
        public String Adder { get; set; }
        [DisplayName("Adres strony internetowej")]
        public String Link { get; set; }
        public String Email { get; set; }
        public String Przyjecia { get; set; }
        [DisplayName("Maksymalna liczba gości")]
        public int MaxLiczbaGosci { get; set; }
        [DisplayName("Dodatkowe uwagi")]
        public String DodatkoweUwagi { get; set; }
        public DateTime Termin { get; set; }
        public int Budzet { get; set; }

        [DisplayName("Opłacony")]
        public bool OplaconyAbonament { get; set; }
    }

    public class Hotel : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DisplayName("Ilość stolików")]
        public int iloscStolikow { get; set; }
        [DisplayName("Rodzaj kuchni")]
        public String rodzajKuchni { get; set; }
        [DisplayName("Dodatkowe oczekiwania")]
        public String dodatkoweOczekiwania { get; set; }
        [DisplayName("Dodatkowe usługi")]
        public String dodatkoweUslugi { get; set; }
        [DisplayName("Klimat lokalu")]
        public String klimatLokalu { get; set; }
    }

    public class DomWeselny : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DisplayName("Ilość stolików")]
        public int iloscStolikow { get; set; }
        [DisplayName("Rodzaj kuchni")]
        public String rodzajKuchni { get; set; }
        [DisplayName("Dodatkowe oczekiwania")]
        public String dodatkoweOczekiwania { get; set; }
        [DisplayName("Dodatkowe usługi")]
        public String dodatkoweUslugi { get; set; }
        [DisplayName("Klimat lokalu")]
        public String klimatLokalu { get; set; }
    }

    public class Restauracja : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DisplayName("Ilość stolików")]
        public int iloscStolikow { get; set; }
        [DisplayName("Rodzaj kuchni")]
        public String rodzajKuchni { get; set; }
        [DisplayName("Dodatkowe oczekiwania")]
        public String dodatkoweOczekiwania { get; set; }
        [DisplayName("Dodatkowe usługi")]
        public String dodatkoweUslugi { get; set; }
        [DisplayName("Klimat lokalu")]
        public String klimatLokalu { get; set; }

        //dodatkowe oczekiwania (parking, miejsce do tańca, wlasna muzyka, palarnia, klimatyzacja, ogródek)
        //dodatkowe usługi(dj, zespol, wodzirej, fotograf, fotobudka)
    }

    public class Klub : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DisplayName("Dodatkowe oczekiwania")]
        public String dodatkoweOczekiwania { get; set; }
      
        [DisplayName("Klimat lokalu")]
        public String klimatLokalu { get; set; }
    }

    public class Karczma : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DisplayName("Ilość stolików")]
        public int iloscStolikow { get; set; }
        [DisplayName("Rodzaj kuchni")]
        public String rodzajKuchni { get; set; }
        [DisplayName("Dodatkowe oczekiwania")]
        public String dodatkoweOczekiwania { get; set; }
        [DisplayName("Dodatkowe usługi")]
        public String dodatkoweUslugi { get; set; }
        [DisplayName("Klimat lokalu")]
        public String klimatLokalu { get; set; }
    }

    public class Kawiarnia :Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DisplayName("Ilość stolików")]
        public int iloscStolikow { get; set; }
        [DisplayName("Rodzaj kawy")]
        public String rodzajKawy { get; set; }
       
        [DisplayName("Klimat lokalu")]
        public String klimatLokalu { get; set; }
    }

    public class Pub : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DisplayName("Ilość stolików")]
        public int iloscStolikow { get; set; }
        [DisplayName("Rodzaj kuchni")]
        public String rodzajKuchni { get; set; }
        [DisplayName("Dodatkowe oczekiwania")]
        public String dodatkoweOczekiwania { get; set; }
        [DisplayName("Dodatkowe usługi")]
        public String dodatkoweUslugi { get; set; }
        [DisplayName("Klimat lokalu")]
        public String klimatLokalu { get; set; }
    }

    public class SalaBankietowa : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DisplayName("Ilość stolików")]
        public int iloscStolikow { get; set; }
        [DisplayName("Rodzaj kuchni")]
        public String rodzajKuchni { get; set; }
        [DisplayName("Dodatkowe oczekiwania")]
        public String dodatkoweOczekiwania { get; set; }
        [DisplayName("Dodatkowe usługi")]
        public String dodatkoweUslugi { get; set; }
        [DisplayName("Klimat lokalu")]
        public String klimatLokalu { get; set; }
    }

    public class SPA : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DisplayName("Rodzaj zabiegów")]
        public String rodzajZabiegow { get; set; }
        [DisplayName("Dodatkowe oczekiwania")]
        public String dodatkoweOczekiwania { get; set; }
        [DisplayName("Dodatkowe usługi")]
        public String dodatkoweUslugi { get; set; }
        [DisplayName("Klimat lokalu")]
        public String klimatLokalu { get; set; }
    }

    public class Agroturystyczne : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
    }

    public class DomkiLetniskowe : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
       
    }

    public class Apartament : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DisplayName("Klimat lokalu")]
        public String klimatLokalu { get; set; }
    }

    //public class OsrodekSzkoleniowoWypoczynkowy : Lokal
    //{

    //}

    public class CentrumEventowe : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DisplayName("Ilość stolików")]
        public int iloscStolikow { get; set; }
        [DisplayName("Rodzaj kuchni")]
        public String rodzajKuchni { get; set; }
        [DisplayName("Dodatkowe oczekiwania")]
        public String dodatkoweOczekiwania { get; set; }
        [DisplayName("Dodatkowe usługi")]
        public String dodatkoweUslugi { get; set; }
        [DisplayName("Klimat lokalu")]
        public String klimatLokalu { get; set; }
    }

    public class EscapeRoom : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DisplayName("Klimat lokalu")]
        public String klimatLokalu { get; set; }
    }

    public class SalaZabaw : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
       
    }

    public class SciankaWspinaczkowa : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
    }

    public class Mieszkanie : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
       
        [DisplayName("Klimat lokalu")]
        public String klimatLokalu { get; set; }
    }

    

    public class CentrumRekreacji : Lokal
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
       
    }

    //public class Hostel : Lokal
    //{

    //}
}
