using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheddarChess.Game
{
    /// <summary>
    /// Represents a game board.
    /// </summary>
    public class Board
    {
        public List<Piece> Pieces { get; }
        public Dictionary<Space, Piece> Spaces { get; }

        public Board() 
        {
            foreach (File file in Enum.GetValues(typeof(File)))
            {
                for (byte rank = Space.MIN_RANK_FILE_VALUE;
                    rank <= Space.MAX_RANK_FILE_VALUE;
                    rank++)
                {
                    Spaces.Add(new Space(file, rank), null);
                }
            }
        }
    }
}
