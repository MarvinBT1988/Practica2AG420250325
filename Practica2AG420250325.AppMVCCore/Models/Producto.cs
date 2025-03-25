using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practica2AG420250325.AppMVCCore.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }
    [Display(Name ="Bodega")]
    public int? BodegaId { get; set; }
    [Display(Name = "Marca")]
    public int? MarcaId { get; set; }

    public string? Notas { get; set; }

    public virtual Bodega? Bodega { get; set; }

    public virtual Marca? Marca { get; set; }
}
