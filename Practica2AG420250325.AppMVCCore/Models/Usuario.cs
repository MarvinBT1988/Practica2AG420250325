﻿using System;
using System.Collections.Generic;

namespace Practica2AG420250325.AppMVCCore.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Rol { get; set; } = null!;
}
