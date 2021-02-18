using System;

namespace CheddarChess.Game
{
    /// <summary>
    /// Represents a board space.
    /// </summary>
    public struct Space
    {
        private const byte MIN_ROW_VALUE = 1;
        private const byte MAX_ROW_VALUE = 8;

        public Column Column { get; }
        public byte Row { get; }

        public Space(Column column, byte row)
        {
            if (row < MIN_ROW_VALUE || row > MAX_ROW_VALUE)
            {
                throw new ArgumentException($"Row value must be between 1 and 8 (inclusive).");
            }
            Column = column;
            Row = row;
        }

        public byte HorizontalDistanceTo(Space otherSpace) => (byte)Math.Abs(Row - otherSpace.Row);
        public byte VerticalDistanceTo(Space otherSpace) => 
            (byte)Math.Abs(Column - otherSpace.Column);
        public byte DistanceTo(Space otherSpace) =>
            (byte)(HorizontalDistanceTo(otherSpace) + VerticalDistanceTo(otherSpace));
    }

    /// <summary>
    /// Represents a board column.
    /// </summary>
    public enum Column
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
