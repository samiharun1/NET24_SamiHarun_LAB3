using System;
using System.Collections.Generic;

namespace NET24_SamiHarun_LAB3.Models;

public partial class Personal
{
    public int Id { get; set; }

    public string? Namn { get; set; }

    public string? Befattning { get; set; }

    public virtual ICollection<Betyg> Betygs { get; set; } = new List<Betyg>();
}
