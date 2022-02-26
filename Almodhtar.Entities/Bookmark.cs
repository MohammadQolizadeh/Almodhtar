﻿using Almodhtar.Entities.identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almodhtar.Entities
{
    public class Bookmark
    {
        public string NewsId { get; set; }
        public int UserId { get; set; }

        public virtual News News { get; set; }
        public virtual User User { get; set; }
    }
}
