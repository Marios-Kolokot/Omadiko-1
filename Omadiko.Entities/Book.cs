﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
    class Book
    {
        public int BookId { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public bool IsAvailable { get; set; }
    }
}
