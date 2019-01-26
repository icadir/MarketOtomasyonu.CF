﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.Entities
{
    public class BasketViewModel
    {
        public int UrunId { get; set; }
        public int MultiUrunId { get; set; }
        public decimal GPiece { get; set; } = 1;
        public decimal BPiece { get; set; }
        public decimal BPrice { get; set; }
        public string Explanation { get; set; }
        public string ProductName { get; set; }

        public override string ToString() => $"{ProductName} -- {(GPiece* BPrice):c2} -- {Explanation}";

    }
}