using System.Drawing;

namespace CheddarChess.Game.Pieces
{
    public class Bishop : Piece
    {
        public static string Name => "Bishop";
        public static byte Value => 3;
        public override char Symbol => Color == Color.White ? 'B' : 'b';

        public Bishop(Color color) : base(color) { }
    }
}
