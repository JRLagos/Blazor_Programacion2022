using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Usuario
{
    [Required(ErrorMessage = "El Campo Codigo Es Obligatorio")]
    public string  Codigo { get; set; }
    [Required(ErrorMessage = "El Campo Nombre Es Obligatorio")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "El Campo Rol Es Obligatorio")]
    public string  Rol { get; set; }
    public string Clave { get; set; }
    public bool EstaActivo { get; set; }
}

