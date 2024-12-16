using System;
using System.Collections.Generic;

namespace Note_APP.Models;

public partial class Note
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public long? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public long? DeletedBy { get; set; }

    public long? DeletedAt { get; set; }
}
