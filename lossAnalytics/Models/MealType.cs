﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lossAnalytics.Models
{
    public class MealType : Base.Entity
    {
        public string Name { get; set; }
        public string Order { get; set; }
    }
}