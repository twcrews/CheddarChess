using System;
using System.Drawing;

namespace CheddarChess.Game
{
    /// <summary>
    /// Represents a game piece.
    /// </summary>
    public abstract class Piece
    {
        public Color Color { get; init; }
        public Space Space { get; set; }

        public Piece(Color color, Space space)
        {
            if (color != Color.White && color != Color.Black)
            {
                throw new ArgumentException($"Color value must be Black or White.");
            }
            Color = color;
            Space = space;
        }
    }
}
