using System;
using System.Collections.Generic;

namespace Practica2AG420250325.AppMVCCore.Models;

public partial class Bodega
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Notas { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
