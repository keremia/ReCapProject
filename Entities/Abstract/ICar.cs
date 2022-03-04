﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract
{
    public interface ICar
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public string DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
