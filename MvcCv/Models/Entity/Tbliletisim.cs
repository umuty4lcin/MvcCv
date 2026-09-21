using System;
using System.Collections.Generic;

namespace MvcCv.Models.Entity;

public partial class Tbliletisim
{
    public int Id { get; set; }

    public string? AdSoyad { get; set; }

    public string? Mail { get; set; }

    public string? Konu { get; set; }

    public string? Mesaj { get; set; }

    public DateOnly? Tarih { get; set; }
}
