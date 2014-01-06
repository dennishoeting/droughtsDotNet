using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DroughtsCommon {

    public struct Position {

        public int I { get; private set; }
        public int J { get; private set; }

        public Position(int i, int j) : this() {
            this.I = i;
            this.J = j;
        }

        public static bool operator==(Position position1, Position position2) {
            return position1.I == position2.I && position1.J == position2.J;
        }

        public static bool operator !=(Position position1, Position position2) {
            return !(position1 == position2);
        }
    }
}
