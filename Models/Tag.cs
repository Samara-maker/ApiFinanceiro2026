using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiFinanceiro.Models
{
    [Table("tags"), PrimaryKey(nameof(Id))]
    public class Tag
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public required string Nome { get; set; }

        public ICollection<Despesa> Despesas { get; set; }
}
}
