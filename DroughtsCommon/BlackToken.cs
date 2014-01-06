using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace DroughtsCommon {
    public class BlackToken : TokenBase {

        internal BlackToken(Position position)
            : base(position) {
        }

        internal override ReadOnlyCollection<Position> GetPossibleJumpDirections() {
            throw new NotImplementedException();
        }

        internal override ReadOnlyCollection<Position> GetPossibleJumpDirectionsFrom(Position position) {
            throw new NotImplementedException();
        }
    }
}
