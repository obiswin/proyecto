using System;
using System.Collections.Generic;

namespace admin.Models;

public partial class Carrito
{
    public int IdCarrito { get; set; }

    public string? Nombres { get; set; }

    public int? IdCliente { get; set; }

    public int? IdProducto { get; set; }

    public int? Cantidad { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
