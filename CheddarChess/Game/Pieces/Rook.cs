using System.Drawing;

namespace CheddarChess.Game.Pieces
{
    public class Rook : Piece
    {
        public static string Name => "Rook";
        public static byte Value => 5;
        public override char Symbol => Color == Color.White ? 'R' : 'r';

        public Rook(Color color) : base(color) { }
    }
}
