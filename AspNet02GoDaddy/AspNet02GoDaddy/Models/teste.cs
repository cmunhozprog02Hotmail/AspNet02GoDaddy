using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNet02GoDaddy.Models
{
    [Table("Teste")]
    public class teste
    {
        public int TesteId { get; set; }
        public string Descricao { get; set; }
    }
}