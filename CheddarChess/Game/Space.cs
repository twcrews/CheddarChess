using System;

namespace CheddarChess.Game
{
    /// <summary>
    /// Represents a board space.
    /// </summary>
    public class Space
    {
        public const byte MIN_RANK_FILE_VALUE = 1;
        public const byte MAX_RANK_FILE_VALUE = 8;

        public File File { get; }
        public byte Rank { get; }
        public Piece Piece { get; set; }

        public Space(File file, byte rank)
        {
            if (rank < MIN_RANK_FILE_VALUE || rank > MAX_RANK_FILE_VALUE)
            {
                throw new ArgumentException("Rank value must be between 1 and 8 (inclusive).");
            }
            File = file;
            Rank = rank;
        }

        public string Symbol => $"{File.ToString().ToLower()}{Rank}";

        public byte HorizontalDistanceTo(Space otherSpace) => 
            (byte)Math.Abs(Rank - otherSpace.Rank);
        public byte VerticalDistanceTo(Space otherSpace) => 
            (byte)Math.Abs(File - otherSpace.File);
        public byte DistanceTo(Space otherSpace) =>
            (byte)(HorizontalDistanceTo(otherSpace) + VerticalDistanceTo(otherSpace));
    }

    /// <summary>
    /// Represents a board file.
    /// </summary>
    public enum File
    {
        A = 1,
        B,
        C,
        D,
        E,
        F,
        G,
        H
    }
}
