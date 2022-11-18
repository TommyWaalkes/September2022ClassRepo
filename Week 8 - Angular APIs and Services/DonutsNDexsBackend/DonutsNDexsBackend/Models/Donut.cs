using System;
using System.Collections.Generic;

namespace DonutsNDexsBackend.Models;

public partial class Donut
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Calories { get; set; }

    public string? Photo { get; set; }

    public string? PhotoAttribution { get; set; }
}
