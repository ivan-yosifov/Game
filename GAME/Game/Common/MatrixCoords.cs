﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Common
{
    class MatrixCoords
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public MatrixCoords(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
}
