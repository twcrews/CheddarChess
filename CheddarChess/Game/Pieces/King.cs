using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CheddarChess.Game.Pieces
{
    public class King : Piece
    {
        public static string Name => "King";
        public static byte Value => 0;

        public King(Color color, Space space) : base(color, space) 
        {
            Name = "King";
        }
    }
}
