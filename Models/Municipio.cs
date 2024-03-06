using System;
using System.Collections.Generic;

namespace admin.Models;

public partial class Municipio
{
    public int IdProvincia { get; set; }

    public string Descripcion { get; set; } = null!;

    public string IdDepartamento { get; set; } = null!;
}
