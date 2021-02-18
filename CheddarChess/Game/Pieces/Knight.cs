using System.Drawing;

namespace CheddarChess.Game.Pieces
{
    public class Knight : Piece
    {
        public static string Name => "Knight";
        public static byte Value => 3;
        public override char Symbol => Color == Color.White ? 'N' : 'n';

        public Knight(Color color) : base(color) { }
    }
}
