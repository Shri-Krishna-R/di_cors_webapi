﻿using System;
using System.Collections.Generic;

namespace di_cors_webapi.Models.EF;

public partial class Product
{
    public int PId { get; set; }

    public string? PName { get; set; }

    public string? PCategory { get; set; }

    public int? PPrice { get; set; }

    public bool? PIsInStock { get; set; }
}
