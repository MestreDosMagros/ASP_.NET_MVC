using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_.NET_MVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}
