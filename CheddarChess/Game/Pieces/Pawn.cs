using System.Drawing;

namespace CheddarChess.Game.Pieces
{
    public class Pawn : Piece
    {
        public static string Name => "Pawn";
        public static byte Value => 1;
        public override char Symbol => Color == Color.White ? 'P' : 'p';

        public Pawn(Color color) : base(color) { }
    }
}
