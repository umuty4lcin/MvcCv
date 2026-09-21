using System;
using System.Collections.Generic;

namespace MvcCv.Models.Entity;

public partial class TblYeteneklerim
{
    public int Id { get; set; }

    public string? Yetenek { get; set; }

    public byte? Oran { get; set; }
}
