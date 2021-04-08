using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace montanari.giorgia._5H.SecondaWeb.Models
{
   
    public class Prenotazione {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool? Partecipazione { get; set; }
    }


}
