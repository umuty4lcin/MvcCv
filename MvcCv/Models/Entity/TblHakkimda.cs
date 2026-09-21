using System;
using System.Collections.Generic;

namespace MvcCv.Models.Entity;

public partial class TblHakkimda
{
    public int Id { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? Adres { get; set; }

    public string? Telefon { get; set; }

    public string? Mail { get; set; }

    public string? Açıklama { get; set; }

    public string? Resim { get; set; }
}
