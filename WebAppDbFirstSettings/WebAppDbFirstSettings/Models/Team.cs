﻿using System;
using System.Collections.Generic;

namespace WebAppDbFirstSettings.Models
{
    public partial class Team
    {
        public Team()
        {
            Players = new HashSet<Player>();
        }

        public int Id { get; set; }
        public string TeamName { get; set; } = null!;

        public virtual ICollection<Player> Players { get; set; }
    }
}
