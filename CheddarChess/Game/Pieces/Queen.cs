using System.Drawing;

namespace CheddarChess.Game.Pieces
{
    public class Queen : Piece
    {
        public static string Name => "Queen";
        public static byte Value => 9;
        public override char Symbol => Color == Color.White ? 'Q' : 'q';

        public Queen(Color color) : base(color) { }
    }
}
