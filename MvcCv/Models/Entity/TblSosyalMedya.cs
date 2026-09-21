using System;
using System.Collections.Generic;

namespace MvcCv.Models.Entity;

public partial class TblSosyalMedya
{
    public int Id { get; set; }

    public string? Ad { get; set; }

    public string? Link { get; set; }

    public bool? Durum { get; set; }
}
