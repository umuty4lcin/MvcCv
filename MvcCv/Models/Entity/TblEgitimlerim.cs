using System;
using System.Collections.Generic;

namespace MvcCv.Models.Entity;

public partial class TblEgitimlerim
{
    public int Id { get; set; }

    public string? Baslik { get; set; }

    public string? Altaslik1 { get; set; }

    public string? AltBaslik2 { get; set; }

    public string? Gno { get; set; }

    public string? Tarih { get; set; }
}
