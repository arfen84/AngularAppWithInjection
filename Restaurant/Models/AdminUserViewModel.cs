using Restauracje.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class AdminUserViewModel
    {
        public List<Hotel> hotele { get; set; }
        public List<DomWeselny> domyWeselne { get; set; }
        public List<Restauracja> restauracje { get; set; }
        public List<Klub> kluby { get; set; }
        public List<Karczma> karczmy { get; set; }
        public List<Kawiarnia> kawiarnie { get; set; }
        public List<Pub> puby { get; set; }
        public List<SalaBankietowa> saleBankietowe { get; set; }
        public List<SPA> spa { get; set; }
        public List<Agroturystyczne> agro { get; set; }
        public List<DomkiLetniskowe> domkiLetniskowe { get; set; }
        public List<Apartament> apartamenty { get; set; }
        public List<CentrumEventowe> centrumEventowe { get; set; }
        public List<EscapeRoom> escapeRomm { get; set; }
        public List<SalaZabaw> salaZabaw { get; set; }
        public List<SciankaWspinaczkowa> scianka { get; set; }
        public List<Mieszkanie> mieszkanie { get; set; }
        public List<CentrumRekreacji> rekreacji { get; set; }
    }

    public class APIParams
    {
        public string api_token { get; set; }
        public string[][][] invoice { get; set; }

    }
}
