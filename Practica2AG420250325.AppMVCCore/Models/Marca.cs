using System;
using System.Collections.Generic;

namespace Practica2AG420250325.AppMVCCore.Models;

public partial class Marca
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public byte[]? ImagenBytes { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
