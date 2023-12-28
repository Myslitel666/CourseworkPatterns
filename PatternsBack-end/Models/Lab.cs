using System;
using System.Collections.Generic;

namespace PatternsBack_end.Models;

public partial class Lab
{
    public int LabId { get; set; }

    public string? LabName { get; set; }

    public string? LabIcon { get; set; }

    public string? LabLink { get; set; }
}
