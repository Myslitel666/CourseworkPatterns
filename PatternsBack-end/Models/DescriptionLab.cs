using System;
using System.Collections.Generic;

namespace PatternsBack_end.Models;

public partial class DescriptionLab
{
    public int DescriptionLabsId { get; set; }

    public string? LabName { get; set; }

    public string? LabDescription { get; set; }

    public string? ImageUrl { get; set; }

    public int? Priority { get; set; }

    public string? LabLink { get; set; }
}
