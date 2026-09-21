using System;
using System.Collections.Generic;

namespace MvcCv.Models.Entity;

public partial class TblAdmin
{
    public int Id { get; set; }

    public string? KullaniciAdi { get; set; }

    public string? Sifre { get; set; }
}
