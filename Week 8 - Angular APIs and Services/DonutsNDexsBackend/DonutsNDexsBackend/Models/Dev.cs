using System;
using System.Collections.Generic;

namespace DonutsNDexsBackend.Models;

public partial class Dev
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Innovation { get; set; }

    public int? Year { get; set; }
}
