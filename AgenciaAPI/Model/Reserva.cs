using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaAPI.Model
{
    [Table("reservas")]
    public class Reserva
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("NomeCompleto")]
        [Required]
        public string Nome { get; set; } = string.Empty;

        [Column("NumeroCpf")]
        public long CPF { get; set; }

        [Column("NumeroTelefone")]
        public long Numero { get; set; }

        [Column("DataViagem")]
        public DateTime CheckIn { get; set; } 

        [Column("QuantidadePessoas")]
        public long Pessoas { get; set; }

        [Column("LocalDestino")]
        public string Destino { get; set; } = string.Empty;

        [Column("DestinoURL")]
        public string DestinoURL { get; set; } = string.Empty;

        [Column("ValorPassagem")]
        public double Valor {  get; set; }


    }
}
