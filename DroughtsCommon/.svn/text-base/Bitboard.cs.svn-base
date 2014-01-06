using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DroughtsCommon {
    public struct Bitboard {

        public static readonly Bitboard Empty = new Bitboard();


        public long NormalTokens { get; private set; }
        public long LadyTokens { get; private set; }

        public Bitboard(long normalTokens, long LadyTokens)
            : this() {
            this.NormalTokens = normalTokens;
            this.LadyTokens = LadyTokens;
        }

        public static bool operator ==(Bitboard bitboard1, Bitboard bitboard2) {
            return bitboard1.NormalTokens == bitboard2.NormalTokens && bitboard1.LadyTokens == bitboard2.LadyTokens;
        }

        public static bool operator !=(Bitboard bitboard1, Bitboard bitboard2) {
            return !(bitboard1 == bitboard2);
        }
    }
}

