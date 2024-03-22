using System.ComponentModel.DataAnnotations.Schema;

namespace api.Repository;

public class Evento
{
    [Column("id")]
        public int Id  { get; set; }

         [Column("data_evento")]
        public DateTime DataEvento { get; set; }

        [Column("total_ingressos")]
        public int TotalIngressos {get; set;}

        [Column("descricao")]
        public string? Descricao {get; set;}
}