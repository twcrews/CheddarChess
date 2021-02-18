using CheddarChess.Game.Pieces;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace CheddarChess.Game
{
    /// <summary>
    /// Represents a player.
    /// </summary>
    public class Player
    {
        public List<Piece> Pieces { get; }
        public Color Color { get; }

        public Player(Color color)
        {
            if (color != Color.White && color != Color.Black)
            {
                throw new ArgumentException("Color value must be Black or White.");
            }
            Color = color;

            Pieces = new List<Piece>
            {
                new King(color),
                new Queen(color),
                new Bishop(color), new Bishop(color),
                new Knight(color), new Knight(color),
                new Rook(color), new Rook(color)
            };

            for (int i = 0; i < Space.MAX_RANK_FILE_VALUE; i++)
            {
                Pieces.Add(new Pawn(color));
            }
        }
    }
}
