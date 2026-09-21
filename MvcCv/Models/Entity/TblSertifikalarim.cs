using System;
using System.Collections.Generic;

namespace MvcCv.Models.Entity;

public partial class TblSertifikalarim
{
    public int Id { get; set; }

    public string? Aciklama { get; set; }

    public string? Tarih { get; set; }
}
