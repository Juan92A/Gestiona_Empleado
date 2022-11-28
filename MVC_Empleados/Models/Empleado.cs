using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_Empleados.Models;

public partial class Empleado
{
    [Required]
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Correo { get; set; }

    public string? Cargo { get; set; }
    [Required]
    [Display(Name = "Fecha de inicio")]
    [DataType(DataType.Date)]
    public DateTime? FechaInicio { get; set; }
}
