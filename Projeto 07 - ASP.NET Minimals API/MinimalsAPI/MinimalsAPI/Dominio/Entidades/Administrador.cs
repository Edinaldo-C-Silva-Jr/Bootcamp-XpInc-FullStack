using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalsAPI.Dominio.Entidades
{
    /// <summary>
    /// Classe que representa um Administrador no banco de dados.
    /// </summary>
    public class Administrador
    {
        /// <summary>
        /// O identificador único do Administrador.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// O e-mail do administrador.
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// A senha do administrador.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Senha { get; set; } = default!;

        /// <summary>
        /// O perfil do administrador.
        /// </summary>
        [Required]
        [StringLength(10)]
        public string Perfil { get; set; } = default!;
    }
}
