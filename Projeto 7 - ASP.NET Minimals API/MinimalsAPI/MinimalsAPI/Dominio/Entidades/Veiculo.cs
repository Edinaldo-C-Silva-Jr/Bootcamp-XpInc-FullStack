using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MinimalsAPI.Dominio.Entidades
{
    /// <summary>
    /// Classe que representa um veículo que será inserido no banco de dados.
    /// </summary>
    public class Veiculo
    {
        /// <summary>
        /// Identificador único do veículo.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Nome do veículo.
        /// </summary>
        [Required]
        [StringLength(150)]
        public string Nome { get; set; } = default!;

        /// <summary>
        /// Marca do veículo.
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Marca { get; set; } = default!;

        /// <summary>
        /// Ano de lançamento do veículo.
        /// </summary>
        [Required]
        public int Ano { get; set; } = default!;
    }
}
