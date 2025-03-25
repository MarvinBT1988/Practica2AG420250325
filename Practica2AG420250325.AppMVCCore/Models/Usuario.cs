using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practica2AG420250325.AppMVCCore.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;
    [EmailAddress]
    public string Email { get; set; } = null!;
    [Display(Name = "Contraseña")]
    [DataType(DataType.Password)]
    [StringLength(100, MinimumLength = 5, ErrorMessage = "El password debe tener entre 5 y 100 caracteres.")]
    public string Password { get; set; } = null!;

    public string Rol { get; set; } = null!;
}
