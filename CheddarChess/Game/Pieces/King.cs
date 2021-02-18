using System.Drawing;

namespace CheddarChess.Game.Pieces
{
    public class King : Piece
    {
        public static string Name => "King";
        public static byte Value => 0;
        public override char Symbol => Color == Color.White ? 'K' : 'k';

        public King(Color color) : base(color) { }
    }
}
